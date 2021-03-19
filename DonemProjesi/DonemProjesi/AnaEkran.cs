using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
//HİLAL ZEHRA AYDIN
//190707078
//DÖNEM PROJESİ 1 
//YILAN OYUNU 
namespace DonemProjesi
{
    public partial class AnaEkran : Form
    {
        public int x = 2, y = 2;
        public string oyuncuAdi = string.Empty;  //oyuncu adı boş olamaz
        public double puan_degeri; //oyundaki puanımız
        public double saniye; //gecen süre 
        public double gecici; // puanlamada kullanılan süre
        public double dakika; // sürenin gösterildiği txt de kullanmak için
        public double net_zaman; //oyunu puanlmak için
        public int seviye; //oyunun seviyesi
        public int degisim_x = 0; //yılanın hareketine bağlı değişim x 
        public int degisim_y = 0; //yılanın hareketine bağlı değişim x 
        public int basladi_mi = 0; // ilk kez b tuşuna baıp basmadığı kontrölü
        public double sayac = 0; //kaç yem yediğinin kontrolü
        public int son_x = 0; // değişen x  konumunu saklar
        public int son_y = 0; //değişen y konumunu saklar
        public bool oyun = true; // oyunun çalışmasını kontrol eder
        public List<Konum> kuyruk = new List<Konum>(); //kuruğun konumu ve oluşumu
        public Konum yem = new Konum(-1, -1); // yemin konumu değiştirerek oluşmamış hale getirme
        public bool yeni_oyun = false; //yanınca oyunu tekrar oyanyıp oynamadığını kontrol eder
        public void HareketEtThread() // programı yormadan sonsuz döngüde çalışmasını sağlar
        {
            while (oyun) // yılanın hareet döngüsü 
            {

                x += degisim_x; //yılanın değişen x konumu
                y += degisim_y; //yılanın değişen y konumu
                YilaninHareketi(); 
                Thread.Sleep(seviye); //yılanın animasyonlu hareketi ve seviyesi 
            }
        }
        public void HareketEt()
        {
            if (yeni_oyun) // yanınca yeniden oynayıp oynamadığı kontrol edildi.
            {
                // oyunu yeni oynadığında başlarken açılan özellikleri visible= false olması sağlandı
                kolayButton.Visible = false;
                zorButton.Visible = false;
                button1.Visible = false;
                txtKisi.Visible = false;
                yardım.Visible = false;
                btnKisiKaydet.Visible = false;
            } //oyuncu yandığında oyunu tekrae açarsa 
            kuyruk.Add(new Konum(0, 0)); //kuyruğun konumu sıfırladım
            YilaninHareketi(); 
        }
        string son_tus; //oyuncu en son hangi tuşa basmış onun anlaşılması
        public void YilaninHareketi()
        {
            Random rnd = new Random(); 
            Bitmap bitmap = new Bitmap(500, 500); //oyun platformu oluşturuldu ve boyutlandırıldı
            if (kuyruk.Count != 1) //kuyruğun konumu 1 den farklıysa
            {
                for (int i = 1; i < kuyruk.Count; i++) //kuruk değerine kadar gitme
                {
                    //yılan kendi kuyruğuna çarparsa
                    if ((kuyruk[i].X == x) && (kuyruk[i].Y == y) && kuyruk.Count > 2 && son_tus != "d")
                    {
                        DialogResult sonuc = MessageBox.Show("Yeni Oyun", "Kaybettiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        //evet yada hayır fark etmez isim , süre, puan dosyaya yazılır
                        KisiKaydet(txtKisi.Text, gecici, puan_degeri);
                        if (sonuc == DialogResult.Yes)
                        {
                            //oyunun başlatma ve durdurma butonları tetiklendi
                            //oyun önce durduruldu , sıfırlandı ve tekrar başlatıldı
                            oyun = true;
                            son_tus = "d";

                            degisim_y = 0;
                            degisim_x = 0;


                            son_tus = "d";

                            x = 2;
                            y = 2;

                            basladi_mi = 0;
                            saniye = 0;
                            dakika = 0;
                            puan_degeri = 0;
                            sayac = 0;
                            gecici = 0;

                            kuyruk.Clear();
                            HareketEt();

                            son_tus = "b";

                            oyun = true;
                            degisim_x = 1;
                            degisim_y = 0;
                            basladi_mi += 1;

                            son_x = degisim_x;
                            son_y = degisim_y;
              
                        }
                        else
                        {
                            //oyun döngüsü durdurulup oyundan çıkıldı.
                            oyun = false;
                            Environment.Exit(0);
                            return;
                        }

                    }
                }
            }
            //yemi alma ve puanlama 
            if ((x == yem.X) && y == yem.Y) //yılanın başı yemin üstünde ise 
            {
                sayac++; //kaç yem yedi
                net_zaman = saniye / sayac; // yemi kaç saniyede yedi
                kuyruk.Add(new Konum(yem.X, yem.Y));// Kuyruk ekleme kısmı.
                if ((sayac >= 1) && (net_zaman <= 100))  //yem yedi ve 100 saniyeden az sürede mi yedi
                {
                    puan_degeri = puan_degeri + (100 / net_zaman); // puanlamanın yapılması
                    if (yem.X == 1 || yem.Y == 1 || yem.X == 50 || yem.Y == 50) 
                    {
                        //köşe noktalarında ekstra puan
                        puan_degeri = puan_degeri + 10;
                    }
                }
                yem = new Konum(-1, -1); //yemi oluşmamış hale getirme
            }
            //yılan köşe noktalarına çarparsa
            if (x <= 0 || y <= 0 || x == 51 || y == 51)
            {
                //evet yada hayır fark etmez isim , süre, puan dosyaya yazılır
                KisiKaydet(txtKisi.Text, gecici, puan_degeri);
                DialogResult sonuc = MessageBox.Show("Yeni Oyun", "Kaybettiniz", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (sonuc == DialogResult.Yes)
                {
                    //oyunun başlatma ve durdurma butonları tetiklendi
                    //oyun önce durduruldu , sıfırlandı ve tekrar başlatıldı
                    oyun = true;
                    son_tus = "d"; //son olarak d tuşuna bastı 

                    //değişim değerleri sıfırlandı
                    degisim_y = 0; 
                    degisim_x = 0;
                    
                   //ikinci ke d tuşu tetiklendi
                   //oyun sıfırlandı , değerler sıfırlandı
                    son_tus = "d";
                   //yılanın konumu il hali yapıldı
                    x = 2; 
                    y = 2;

                    basladi_mi = 0;
                    saniye = 0;
                    dakika = 0;
                    puan_degeri = 0;
                    sayac = 0;
                    gecici = 0;

                    kuyruk.Clear();
                    HareketEt();

                    //oyun tekrar başlatıldı
                    son_tus = "b";

                    
                    degisim_x = 1;
                    degisim_y = 0;
                    basladi_mi += 1;

                    son_x = degisim_x;
                    son_y = degisim_y;
                    
                }                
                else
                {
                    //oyun döngüsü durdurulup oyundan çıkıldı.
                    oyun = false;
                    Environment.Exit(0);
                    return;
                }
            }

            //yılanın oluşumu 

            for (int i = (x - 1) * 10; i < x * 10; i++) //yılanın x konumu
            {
                for (int j = (y - 1) * 10; j < y * 10; j++) // yılanın y konumu
                {
                    // Parametre pozitif ve Width değerinden küçük olmalıdır.
                    if (i > 0 || j > 0) //Derleme hatalarını önlemek için kontrol edildi
                    {
                        bitmap.SetPixel(i, j, Color.Black); //yılanın boyutu ve rengi verildi 
                    }
                }
            }
        if (kuyruk.Count != 1)
            {
                //kuyruk oluştu
                for (int c = 0; c < kuyruk.Count; c++) //kuruğun değerine kadar gidildi
                {
                    for (int i = (kuyruk[c].X - 1) * 10; i < kuyruk[c].X * 10; i++)
                    {
                        for (int j = (kuyruk[c].Y - 1) * 10; j < kuyruk[c].Y * 10; j++)
                        {
                            //kuyruk dizisinde x ve y noktalarında oluşturuldu
                            bitmap.SetPixel(i, j, Color.Black); // x-y konumları verildi ve renk eklendi
                        }
                    }
                }
            }
             
            kuyruk[0] = new Konum(x, y); //yılanın başı 
            for (int i = kuyruk.Count - 1; i > 0; i--)
            {
                kuyruk[i] = kuyruk[i - 1];  //yılanın başında kaydırma 
            }

            // yemin oluşumu

            if (yem.Y == -1) // yem daha oluşmamışsa
            {
                yem = new Konum(rnd.Next(1, 50), rnd.Next(1, 50)); // yemin rand x ve y değerleri atandı
            }
            for (int a = (yem.X - 1) * 10; a < yem.X * 10; a++)
            {
                for (int b = (yem.Y - 1) * 10; b < yem.Y * 10; b++)
                {
                    //x ve y noktalarında yem oluşturuldu
                    bitmap.SetPixel(a, b, Color.Red); // x-y konumu ve kordinatları verildi , yem oluştu
                }
            }
            pictureBox1.Image = bitmap; // bitmapin picture box1.ımage de uygulanması sağlandı

        }
        public bool KisiKaydet(string yuncuAdi, double gecici, double puanDegeri)
        {
            StreamWriter sw = null;
                //text dosyasının yolu bulundu 
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\skorlar.txt", true);
               // gerekli değişkenler txt ye yaıldı
                sw.WriteLine("Oyuncu Adı : " + oyuncuAdi + " / Süresi :" + gecici+ " / Puan : " + puanDegeri);
                sw.Flush();
                sw.Close();

                return true;     
        }

        public AnaEkran()
        {
            InitializeComponent();
            HareketEt();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            Thread hareketEt = new Thread(new ThreadStart(HareketEtThread));
            hareketEt.Start(); // thread methodu çağrıldı.
        }

        private void yardım_Click(object sender, EventArgs e)
        {
            MessageBox.Show("~~~~HOŞGELDİNİZ ~~~~\n"+"~~~~YILAN OYUNU KURALLARI~~~~ \n" +"Oyunu oynamak için öncelikle isim girişi" +
                " yapıp kişiyi kaydet butonuna tıklayınız . " +
                " "+ "Başlatmak için B tuşunu kullanınız. " + "\n" + "Durdurmak için D tuşunu kullanınız .\n" +
                "Oyunu Sıfırlamak için iki kez üst üste D tuşuna basınız .\n" + "Yandığınızda tekrar oynamak isterseniz \n" +
                  "Evet butonuna bastığınız da oyun aynı seviye ve adla  yeniden başlayacaktır. \n Çıkmak için hayır butonuna basabilirsiniz . \n" +
                  "Yılanın hareketi klavyenizin hareket tuşları ile yapılmaktadır. \n Siz yemleri topladığınızda yediğiniz süre yani " +
                  " 100/net zaman kadar puan alacaksınız " +
                  "Köşe noktalardan aldığınız yemler size +10 puan kazandıracaktır .\n" +
                  "Yılanın başının kuyruğun herhangi bir noktasına değmesi veya \n" +
                  "köse noktalarına çarpmanız halinde yanarsınız . \n" +
                  "Tekrar oynamak sizin tercihiniz :)\n" +
                  "Oyun skorları her seferinde kaydedilir .\n Skoru görüntüle butonundan oyunu ilk açtığınız da görebilirsiniz.\n " +
                  "~~~~İYİ EĞLENCELER :))~~~~" );
        }
        private void kolayButton_CheckedChanged(object sender, EventArgs e)
        {
            seviye = 200; //kolay seviye verildi
        }
        private void zorButton_CheckedChanged(object sender, EventArgs e)
        {
            seviye = 100; //zor seviye verildi
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++; 
            gecici++;
            puanlama.Text = Math.Round(puan_degeri, 1).ToString(); // puandeğerinde virgülden sonra 1 değer gösterme
            if (gecici < 10) //gecici 10 dan kuçükse görüntü güzelliği için önünde 0 koy
            {
                zaman.Text = "0" + dakika.ToString() + ":" + "0" + gecici.ToString();
            }
            else // gecici 10 dan büyükse önüne sıfır koymaya gerek kalmaz
            {
                zaman.Text = "0" + dakika.ToString() + ":" + gecici.ToString();
                if (gecici == 60) // 60 a eşitse dakka değeri oluştu
                {
                    dakika++;
                    zaman.Text = "0" + dakika.ToString() + ":" + gecici.ToString();
                    gecici = 0; //gecici  sıfırlandı
                }
            }


        }
        private void btnKisiKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKisi.Text))
            {
                MessageBox.Show("Oyuncu adı boş olamaz!! Lütfen isminizi girin...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                oyuncuAdi = txtKisi.Text;
                txtKisi.Text = string.Empty;
                txtKisi.Visible = false;
                yardım.Visible = false;
                btnKisiKaydet.Visible = false;
                button1.Visible = false;

                MessageBox.Show("Hoşgeldiniz Sn. " + oyuncuAdi + ". Oyuna başlayabilirsiniz!! Başlamak için B tuşuna basınız..", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dosya_yolu = System.Environment.CurrentDirectory+"\\skorlar.txt";

            Process.Start("notepad.exe", dosya_yolu);

        }

        private void form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer isim soyisimlerde B ve D harfleri varsa bunları filtreye sok.
            // oyuncuAdi boş ise oyuna başlatma eğer doluysa buraya girme.
            if (string.IsNullOrEmpty(oyuncuAdi))
            {
                return;
            }
            else
            {
                if (e.KeyCode == Keys.B)
                {
                    son_tus = "b";
                    kolayButton.Visible = false;
                    zorButton.Visible = false;
                    if (basladi_mi == 0 && groupBox1.Visible == true)
                    {

                        groupBox1.Visible = false;

                        degisim_x = 1;
                        degisim_y = 0;

                        basladi_mi += 1;

                        son_x = degisim_x;
                        son_y = degisim_y;

                        timer1.Start();

                    }
                    else if (groupBox1.Visible == true)
                    {
                        groupBox1.Visible = false;
                        timer1.Start();

                    }
                    else if (groupBox1.Visible == false)
                    {
                        groupBox1.Visible = true;
                        timer1.Stop();
                        saniye = 0;
                        dakika = 0;
                        puan_degeri = 0;
                        sayac = 0;
                        gecici = 0;
                    }

                    degisim_y = son_y;
                    degisim_x = son_x;
                }

                if (e.KeyCode == Keys.D)
                {
                    son_tus = "d";
                    if (groupBox1.Visible == false)
                    {
                        degisim_y = 0;
                        degisim_x = 0;
                        groupBox1.Visible = true;
                        timer1.Stop();

                    }
                    else if (groupBox1.Visible == true)
                    {
                        x = 2;
                        y = 2;

                        degisim_x = 0;
                        degisim_x = 0;

                        basladi_mi = 0;
                        timer1.Stop();
                        saniye = 0;
                        dakika = 0;
                        puan_degeri = 0;
                        sayac = 0;
                        gecici = 0;

                        kuyruk.Clear();
                        //kuyruk[0] = new Konum(x, y);

                       // hareketEt.Suspend();
                        HareketEt();

                        //yem = new Konum(-1, -1);
                    }
                }

                if (e.KeyCode == Keys.Up)
                {
                    degisim_y = -1;
                    degisim_x = 0;

                    son_y = degisim_y;
                    son_x = degisim_x;
                }
                if (e.KeyCode == Keys.Down)
                {
                    degisim_y = 1;
                    degisim_x = 0;

                    son_y = degisim_y;
                    son_x = degisim_x;
                }
                if (e.KeyCode == Keys.Right)
                {
                    degisim_y = 0;
                    degisim_x = 1;

                    son_y = degisim_y;
                    son_x = degisim_x;
                }
                if (e.KeyCode == Keys.Left)
                {
                    degisim_y = 0;
                    degisim_x = -1;

                    son_y = degisim_y;
                    son_x = degisim_x;
                }
            }
        }
    }
}
