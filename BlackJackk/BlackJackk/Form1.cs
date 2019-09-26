using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BlackJackk
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        System.Media.SoundPlayer ses2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer ses3 = new System.Media.SoundPlayer();

        Random Rastgele = new Random();
        int sayac = 0, sayac2=0;
        int oyuncupuan = 0, bilgisayarpuan = 0;
        int toplam = 0;
        int [] sayilar = new int[8];
        int[] deger = new int[8];
    //    int[] sayilar = new int[4];
      //  int[] deger = new int[4];




        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        

        private const int cGrip = 16;
        private const int cCaption = 32;

        int SimdikiWidth = 1600;

        int SimdikiHeight = 900;

        void KartDagitPc1()
        {
            int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picPcKart1.Location.X || y_yeni >= picPcKart1.Location.Y)
            {
                picGoruntu.Location = new Point(x_yeni, y_yeni);
       
                System.Threading.Thread.Sleep(0);

                x_yeni -= 14;
                y_yeni -= 5;
            }
            picGoruntu.Location = new Point(x_eski, y_eski);
            picPcKart1.Visible = true;
        }

        void KartDagitPc2()
        {
            int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picPcKart2.Location.X || y_yeni >= picPcKart2.Location.Y)
            {
                picGoruntu.Location = new Point(x_yeni, y_yeni);
                System.Threading.Thread.Sleep(0);

                x_yeni -= 6;
                y_yeni -= 3;
            }
            picGoruntu.Location = new Point(x_eski, y_eski);
            picPcKart2.Visible = true;
        }

        void KartDagitPc3()
        {
            int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picPcKart3.Location.X || y_yeni >= picPcKart3.Location.Y)
            {
                picGoruntu.Location = new Point(x_yeni, y_yeni);
                System.Threading.Thread.Sleep(0);
                
                x_yeni -= 10;
                y_yeni -= 7;
            }
            picGoruntu.Location = new Point(x_eski, y_eski);
            picPcKart3.Visible = true;
        }

        void KartDagitPc4()
        {
            int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picPcKart4.Location.X || y_yeni >= picPcKart4.Location.Y)
            {
                picGoruntu.Location = new Point(x_yeni, y_yeni);
                System.Threading.Thread.Sleep(0);

                x_yeni -= 3;
                y_yeni -= 4;
            }
            picGoruntu.Location = new Point(x_eski, y_eski);
            picPcKart4.Visible = true;
        }

        //__________________________

        void KartDagitOyuncu1()
        {
            int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picOyuncuKart1.Location.X || y_yeni <= picOyuncuKart1.Location.Y)
            {
                picGoruntu.Location = new Point(x_yeni, y_yeni);
                System.Threading.Thread.Sleep(0);

                x_yeni -= 14;
                y_yeni += 5;
            }
            picGoruntu.Location = new Point(x_eski, y_eski);
            picOyuncuKart1.Visible = true;
        }

        void KartDagitOyuncu2()
        {
            int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picOyuncuKart2.Location.X || y_yeni <= picOyuncuKart2.Location.Y)
            {
                picGoruntu.Location = new Point(x_yeni, y_yeni);
                System.Threading.Thread.Sleep(0);

                x_yeni -= 7;
                y_yeni += 4;
            }
            picGoruntu.Location = new Point(x_eski, y_eski);
            picOyuncuKart2.Visible = true;
        }

        void KartDagitOyuncu3()
        {
             int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picOyuncuKart3.Location.X || y_yeni <= picOyuncuKart3.Location.Y)
             {
                 picGoruntu.Location = new Point(x_yeni, y_yeni);
                 System.Threading.Thread.Sleep(0);
                 
                 x_yeni -= 8;
                 y_yeni += 8;
             }
             picGoruntu.Location = new Point(x_eski, y_eski);
            picOyuncuKart3.Visible = true;
        }

        void KartDagitOyuncu4()
        {
            int x_eski = picGoruntu.Location.X, y_eski = picGoruntu.Location.Y;
            int x_yeni = picGoruntu.Location.X, y_yeni = picGoruntu.Location.Y;
            while (x_yeni >= picOyuncuKart4.Location.X || y_yeni <= picOyuncuKart4.Location.Y)
            {
                picGoruntu.Location = new Point(x_yeni, y_yeni);
                System.Threading.Thread.Sleep(0);

                x_yeni -= 3;
                y_yeni += 4;
            }
            picGoruntu.Location = new Point(x_eski, y_eski);
            picOyuncuKart4.Visible = true;
        }



        void YeniOyun()
        {
            pictureBox3.Enabled = false;
            sayac = 0;
            sayac2 = 0;
            //   lbBilgisayarSkor.Text = "0";
            //    lbOyuncuSkor.Text = "0";
            Kart1.Text = "0";
            Kart2.Text = "0";
            Kart3.Text = "0";
            Kart4.Text = "0";
            lbPcKart1.Text = "0";
            lbPcKart2.Text = "0";
            lbPcKart3.Text = "0";
            lbPcKart4.Text = "0";
            lbPcToplam.Text = "0";
            ToplamOyuncu.Text = "0";
            picPcKart1.Image = BlackJackk.Properties.Resources.kart_arka4;
            picPcKart2.Image = BlackJackk.Properties.Resources.kart_arka4;
            picPcKart3.Image = BlackJackk.Properties.Resources.kart_arka4;
            picPcKart4.Image = BlackJackk.Properties.Resources.kart_arka4;
            picOyuncuKart1.Image = BlackJackk.Properties.Resources.kart_arka4;
            picOyuncuKart2.Image = BlackJackk.Properties.Resources.kart_arka4;
            picOyuncuKart3.Image = BlackJackk.Properties.Resources.kart_arka4;
            picOyuncuKart4.Image = BlackJackk.Properties.Resources.kart_arka4;

            picPcKart1.Visible = false;
            picPcKart2.Visible = false;
            picPcKart3.Visible = false;
            picPcKart4.Visible = false;
            picOyuncuKart1.Visible = false;
            picOyuncuKart2.Visible = false;
            picOyuncuKart3.Visible = false;
            picOyuncuKart4.Visible = false;



            timer6.Enabled = false;



        }
        protected override void WndProc(ref Message e)
        {
            if (e.Msg==0x84 )
            {
                Point pos = new Point(e.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    e.Result= (IntPtr)2;
                        return;
                }
                if (pos.X>= this.ClientSize.Width-cGrip && pos.Y > this.ClientSize.Height-cGrip)
                {
                    e.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;
            timer2.Interval = 2000;
            timer6.Interval = 1300;

            this.Location = new Point(0, 0);
            Rectangle ClientCozunurluk = new Rectangle();
            ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);
            float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);
            float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);
            this.Scale(OranWidth, OranHeight);
            YeniOyun();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Oyundan çıkmak istediğinizden emin misiniz!", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = BlackJackk.Properties.Resources.kartiste2;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = BlackJackk.Properties.Resources.kartiste;
        }


        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = BlackJackk.Properties.Resources.Sabitle;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = BlackJackk.Properties.Resources.Sabitle2;
        }
        void sayiAtaPc()
        {
/*            deger[0] = 0;
            deger[1] = 0;
            deger[2] = 0;
            deger[3] = 0;
            sayilar[0] = 0;
            sayilar[1] = 0;
            sayilar[2] = 0;
            sayilar[3] = 0;*/
            for (int i = 0; i < 4; i++)
            {
                int sayi = Rastgele.Next(1, 52);
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[i] = sayi;
            }
            for (int j = 4; j < 8; j++)
            {
                if (sayilar[j] == 10 || sayilar[j] == 11 || sayilar[j] == 12 || sayilar[j] == 13 || sayilar[j] == 23 || sayilar[j] == 24 || sayilar[j] == 25 || sayilar[j] == 26 || sayilar[j] == 36 || sayilar[j] == 37 || sayilar[j] == 38 || sayilar[j] == 39 || sayilar[j] == 49 || sayilar[j] == 50 || sayilar[j] == 51 || sayilar[j] == 52)
                {
                    deger[j] = 10;
                }
                else if (sayilar[j] == 1 || sayilar[j] == 14 || sayilar[j] == 27 || sayilar[j] == 40)
                {
                    deger[j] = 1;
                }
                else if (sayilar[j] == 2 || sayilar[j] == 15 || sayilar[j] == 28 || sayilar[j] == 41)
                {
                    deger[j] = 2;
                }
                else if (sayilar[j] == 3 || sayilar[j] == 16 || sayilar[j] == 29 || sayilar[j] == 42)
                {
                    deger[j] = 3;
                }
                else if (sayilar[j] == 4 || sayilar[j] == 17 || sayilar[j] == 30 || sayilar[j] == 43)
                {
                    deger[j] = 4;
                }
                else if (sayilar[j] == 5 || sayilar[j] == 18 || sayilar[j] == 31 || sayilar[j] == 44)
                {
                    deger[j] = 5;
                }
                else if (sayilar[j] == 6 || sayilar[j] == 19 || sayilar[j] == 32 || sayilar[j] == 45)
                {
                    deger[j] = 6;
                }
                else if (sayilar[j] == 7 || sayilar[j] == 20 || sayilar[j] == 33 || sayilar[j] == 46)
                {
                    deger[j] = 7;
                }
                else if (sayilar[j] == 8 || sayilar[j] == 21 || sayilar[j] == 34 || sayilar[j] == 47)
                {
                    deger[j] = 8;
                }
                else if (sayilar[j] == 9 || sayilar[j] == 22 || sayilar[j] == 35 || sayilar[j] == 48)
                {
                    deger[j] = 9;
                }
            }

        }
        void sayiAtaOyuncu()
        {
  /*          deger[0] = 0;
            deger[1] = 0;
            deger[2] = 0;
            deger[3] = 0;
            sayilar[0] = 0;
            sayilar[1] = 0;
            sayilar[2] = 0;
            sayilar[3] = 0;*/
            for (int i = 0; i < 8; i++)
            {
                int sayi = Rastgele.Next(1, 52);
                if (sayilar.Contains(sayi))
                    continue;
                sayilar[i] = sayi;
            }
            for (int j = 0; j < 4; j++)
            {
                if (sayilar[j] == 10 || sayilar[j] == 11 || sayilar[j] == 12 || sayilar[j] == 13 || sayilar[j] == 23 || sayilar[j] == 24 || sayilar[j] == 25 || sayilar[j] == 26 || sayilar[j] == 36 || sayilar[j] == 37 || sayilar[j] == 38 || sayilar[j] == 39 || sayilar[j] == 49 || sayilar[j] == 50 || sayilar[j] == 51 || sayilar[j] == 52)
                {
                    deger[j] = 10;
                }
                else if (sayilar[j] == 1 || sayilar[j] == 14 || sayilar[j] == 27 || sayilar[j] == 40)
                {
                    deger[j] = 1;
                }
                else if (sayilar[j] == 2 || sayilar[j] == 15 || sayilar[j] == 28 || sayilar[j] == 41)
                {
                    deger[j] = 2;
                }
                else if (sayilar[j] == 3 || sayilar[j] == 16 || sayilar[j] == 29 || sayilar[j] == 42)
                {
                    deger[j] = 3;
                }
                else if (sayilar[j] == 4 || sayilar[j] == 17 || sayilar[j] == 30 || sayilar[j] == 43)
                {
                    deger[j] = 4;
                }
                else if (sayilar[j] == 5 || sayilar[j] == 18 || sayilar[j] == 31 || sayilar[j] == 44)
                {
                    deger[j] = 5;
                }
                else if (sayilar[j] == 6 || sayilar[j] == 19 || sayilar[j] == 32 || sayilar[j] == 45)
                {
                    deger[j] = 6;
                }
                else if (sayilar[j] == 7 || sayilar[j] == 20 || sayilar[j] == 33 || sayilar[j] == 46)
                {
                    deger[j] = 7;
                }
                else if (sayilar[j] == 8 || sayilar[j] == 21 || sayilar[j] == 34 || sayilar[j] == 47)
                {
                    deger[j] = 8;
                }
                else if (sayilar[j] == 9 || sayilar[j] == 22 || sayilar[j] == 35 || sayilar[j] == 48)
                {
                    deger[j] = 9;
                }
            }
        }
        void kartCek2()
        {
            int toplam = 0;
            if (sayac == 0)
            {
                sayiAtaOyuncu();
            }
            sayac++;

            if (sayac == 1)
            {
                
                timer2.Enabled = false;
                toplam = deger[0]+deger[1];
                Kart1.Text = sayilar[0].ToString();
                Kart2.Text = sayilar[1].ToString();
                if ((deger[0]==10 && deger[1] == 1)||(deger[0]==1 && deger[1]==10))
                {
                    toplam = 21;
                }
                ToplamOyuncu.Text = toplam.ToString();
                kartKarsilastir();
                if (Convert.ToInt32(ToplamOyuncu.Text) == 21) pictureBox3_Click(this.pictureBox3, null);
                if (Convert.ToInt32(ToplamOyuncu.Text) > 21) pictureBox3_Click(this.pictureBox3, null);

            }
            if (sayac == 2)
            {
                toplam = 0;              
                Kart3.Text = sayilar[2].ToString();
                toplam = deger[0] + deger[1] + deger[2];
                ToplamOyuncu.Text = toplam.ToString();
                timer2.Enabled = false;
                kartKarsilastir();
                if (Convert.ToInt32(ToplamOyuncu.Text) == 21) pictureBox3_Click(this.pictureBox3, null);
                if (Convert.ToInt32(ToplamOyuncu.Text) > 21) pictureBox3_Click(this.pictureBox3, null);
            }

            if (sayac == 3)
            {
                toplam = 0;             
                Kart4.Text = sayilar[3].ToString();
                toplam = deger[0] + deger[1] + deger[2] + deger[3];
                ToplamOyuncu.Text = toplam.ToString();
                timer2.Enabled = false;
                kartKarsilastir();
                pictureBox3_Click(this.pictureBox3, null);

            }

            
        }

        void kartKarsilastir()
        {
            if (Kart1.Text == "1")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (Kart1.Text == "2")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (Kart1.Text == "3")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (Kart1.Text == "4")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (Kart1.Text == "5")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (Kart1.Text == "6")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (Kart1.Text == "7")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (Kart1.Text == "8")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (Kart1.Text == "9")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (Kart1.Text == "10")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (Kart1.Text == "11")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (Kart1.Text == "12")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (Kart1.Text == "13")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (Kart1.Text == "14")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (Kart1.Text == "15")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (Kart1.Text == "16")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (Kart1.Text == "17")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (Kart1.Text == "18")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (Kart1.Text == "19")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (Kart1.Text == "20")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (Kart1.Text == "21")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (Kart1.Text == "22")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (Kart1.Text == "23")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (Kart1.Text == "24")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (Kart1.Text == "25")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (Kart1.Text == "26")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (Kart1.Text == "27")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (Kart1.Text == "28")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (Kart1.Text == "29")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (Kart1.Text == "30")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (Kart1.Text == "31")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (Kart1.Text == "32")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (Kart1.Text == "33")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (Kart1.Text == "34")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (Kart1.Text == "35")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (Kart1.Text == "36")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (Kart1.Text == "37")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (Kart1.Text == "38")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (Kart1.Text == "39")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (Kart1.Text == "40")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (Kart1.Text == "41")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (Kart1.Text == "42")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (Kart1.Text == "43")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (Kart1.Text == "44")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (Kart1.Text == "45")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (Kart1.Text == "46")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (Kart1.Text == "47")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (Kart1.Text == "48")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (Kart1.Text == "49")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (Kart1.Text == "50")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (Kart1.Text == "51")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (Kart1.Text == "52")
            {
                picOyuncuKart1.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }


            if (Kart2.Text == "1")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (Kart2.Text == "2")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (Kart2.Text == "3")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (Kart2.Text == "4")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (Kart2.Text == "5")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (Kart2.Text == "6")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (Kart2.Text == "7")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (Kart2.Text == "8")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (Kart2.Text == "9")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (Kart2.Text == "10")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (Kart2.Text == "11")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (Kart2.Text == "12")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (Kart2.Text == "13")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (Kart2.Text == "14")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (Kart2.Text == "15")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (Kart2.Text == "16")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (Kart2.Text == "17")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (Kart2.Text == "18")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (Kart2.Text == "19")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (Kart2.Text == "20")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (Kart2.Text == "21")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (Kart2.Text == "22")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (Kart2.Text == "23")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (Kart2.Text == "24")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (Kart2.Text == "25")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (Kart2.Text == "26")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (Kart2.Text == "27")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (Kart2.Text == "28")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (Kart2.Text == "29")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (Kart2.Text == "30")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (Kart2.Text == "31")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (Kart2.Text == "32")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (Kart2.Text == "33")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (Kart2.Text == "34")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (Kart2.Text == "35")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (Kart2.Text == "36")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (Kart2.Text == "37")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (Kart2.Text == "38")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (Kart2.Text == "39")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (Kart2.Text == "40")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (Kart2.Text == "41")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (Kart2.Text == "42")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (Kart2.Text == "43")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (Kart2.Text == "44")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (Kart2.Text == "45")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (Kart2.Text == "46")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (Kart2.Text == "47")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (Kart2.Text == "48")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (Kart2.Text == "49")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (Kart2.Text == "50")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (Kart2.Text == "51")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (Kart2.Text == "52")
            {
                picOyuncuKart2.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }


            if (Kart3.Text == "1")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (Kart3.Text == "2")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (Kart3.Text == "3")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (Kart3.Text == "4")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (Kart3.Text == "5")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (Kart3.Text == "6")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (Kart3.Text == "7")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (Kart3.Text == "8")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (Kart3.Text == "9")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (Kart3.Text == "10")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (Kart3.Text == "11")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (Kart3.Text == "12")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (Kart3.Text == "13")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (Kart3.Text == "14")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (Kart3.Text == "15")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (Kart3.Text == "16")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (Kart3.Text == "17")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (Kart3.Text == "18")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (Kart3.Text == "19")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (Kart3.Text == "20")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (Kart3.Text == "21")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (Kart3.Text == "22")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (Kart3.Text == "23")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (Kart3.Text == "24")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (Kart3.Text == "25")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (Kart3.Text == "26")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (Kart3.Text == "27")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (Kart3.Text == "28")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (Kart3.Text == "29")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (Kart3.Text == "30")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (Kart3.Text == "31")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (Kart3.Text == "32")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (Kart3.Text == "33")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (Kart3.Text == "34")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (Kart3.Text == "35")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (Kart3.Text == "36")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (Kart3.Text == "37")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (Kart3.Text == "38")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (Kart3.Text == "39")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (Kart3.Text == "40")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (Kart3.Text == "41")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (Kart3.Text == "42")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (Kart3.Text == "43")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (Kart3.Text == "44")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (Kart3.Text == "45")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (Kart3.Text == "46")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (Kart3.Text == "47")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (Kart3.Text == "48")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (Kart3.Text == "49")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (Kart3.Text == "50")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (Kart3.Text == "51")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (Kart3.Text == "52")
            {
                picOyuncuKart3.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }


            if (Kart4.Text == "1")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (Kart4.Text == "2")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (Kart4.Text == "3")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (Kart4.Text == "4")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (Kart4.Text == "5")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (Kart4.Text == "6")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (Kart4.Text == "7")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (Kart4.Text == "8")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (Kart4.Text == "9")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (Kart4.Text == "10")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (Kart4.Text == "11")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (Kart4.Text == "12")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (Kart4.Text == "13")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (Kart4.Text == "14")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (Kart4.Text == "15")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (Kart4.Text == "16")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (Kart4.Text == "17")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (Kart4.Text == "18")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (Kart4.Text == "19")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (Kart4.Text == "20")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (Kart4.Text == "21")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (Kart4.Text == "22")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (Kart4.Text == "23")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (Kart4.Text == "24")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (Kart4.Text == "25")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (Kart4.Text == "26")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (Kart4.Text == "27")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (Kart4.Text == "28")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (Kart4.Text == "29")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (Kart4.Text == "30")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (Kart4.Text == "31")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (Kart4.Text == "32")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (Kart4.Text == "33")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (Kart4.Text == "34")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (Kart4.Text == "35")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (Kart4.Text == "36")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (Kart4.Text == "37")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (Kart4.Text == "38")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (Kart4.Text == "39")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (Kart4.Text == "40")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (Kart4.Text == "41")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (Kart4.Text == "42")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (Kart4.Text == "43")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (Kart4.Text == "44")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (Kart4.Text == "45")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (Kart4.Text == "46")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (Kart4.Text == "47")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (Kart4.Text == "48")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (Kart4.Text == "49")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (Kart4.Text == "50")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (Kart4.Text == "51")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (Kart4.Text == "52")
            {
                picOyuncuKart4.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }
        }
        void kartCek()
        {
            
            if (sayac2 == 0)
            {
                ses.SoundLocation = Application.StartupPath +  "\\Card.wav";
                ses.Play();
                KartDagitOyuncu1();
                
                timer1.Enabled = false;

            }
            sayac2++;

            if (sayac2 == 1)
            {
                ses.SoundLocation = Application.StartupPath + "\\Card.wav";
                ses.Play();
                KartDagitOyuncu2();
                timer1.Enabled = false;


                
                
            }
            if (sayac2 == 2)
            {

                ses.SoundLocation = Application.StartupPath + "\\Card.wav";
                ses.Play();
                KartDagitOyuncu3();
                
                timer1.Enabled = false;
            }

            if (sayac2 == 3)
            {

                ses.SoundLocation = Application.StartupPath + "\\Card.wav";
                ses.Play();
                KartDagitOyuncu4();
                
                timer1.Enabled = false;
            }
        }

        void pcKartCek()
        {
            if (lbPcKart1.Text == "1")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (lbPcKart1.Text == "2")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (lbPcKart1.Text == "3")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (lbPcKart1.Text == "4")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (lbPcKart1.Text == "5")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (lbPcKart1.Text == "6")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (lbPcKart1.Text == "7")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (lbPcKart1.Text == "8")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (lbPcKart1.Text == "9")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (lbPcKart1.Text == "10")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (lbPcKart1.Text == "11")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (lbPcKart1.Text == "12")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (lbPcKart1.Text == "13")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (lbPcKart1.Text == "14")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (lbPcKart1.Text == "15")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (lbPcKart1.Text == "16")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (lbPcKart1.Text == "17")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (lbPcKart1.Text == "18")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (lbPcKart1.Text == "19")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (lbPcKart1.Text == "20")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (lbPcKart1.Text == "21")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (lbPcKart1.Text == "22")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (lbPcKart1.Text == "23")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (lbPcKart1.Text == "24")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (lbPcKart1.Text == "25")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (lbPcKart1.Text == "26")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (lbPcKart1.Text == "27")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (lbPcKart1.Text == "28")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (lbPcKart1.Text == "29")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (lbPcKart1.Text == "30")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (lbPcKart1.Text == "31")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (lbPcKart1.Text == "32")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (lbPcKart1.Text == "33")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (lbPcKart1.Text == "34")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (lbPcKart1.Text == "35")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (lbPcKart1.Text == "36")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (lbPcKart1.Text == "37")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (lbPcKart1.Text == "38")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (lbPcKart1.Text == "39")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (lbPcKart1.Text == "40")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (lbPcKart1.Text == "41")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (lbPcKart1.Text == "42")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (lbPcKart1.Text == "43")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (lbPcKart1.Text == "44")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (lbPcKart1.Text == "45")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (lbPcKart1.Text == "46")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (lbPcKart1.Text == "47")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (lbPcKart1.Text == "48")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (lbPcKart1.Text == "49")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (lbPcKart1.Text == "50")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (lbPcKart1.Text == "51")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (lbPcKart1.Text == "52")
            {
                picPcKart1.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }


            if (lbPcKart2.Text == "1")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (lbPcKart2.Text == "2")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (lbPcKart2.Text == "3")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (lbPcKart2.Text == "4")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (lbPcKart2.Text == "5")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (lbPcKart2.Text == "6")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (lbPcKart2.Text == "7")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (lbPcKart2.Text == "8")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (lbPcKart2.Text == "9")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (lbPcKart2.Text == "10")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (lbPcKart2.Text == "11")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (lbPcKart2.Text == "12")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (lbPcKart2.Text == "13")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (lbPcKart2.Text == "14")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (lbPcKart2.Text == "15")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (lbPcKart2.Text == "16")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (lbPcKart2.Text == "17")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (lbPcKart2.Text == "18")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (lbPcKart2.Text == "19")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (lbPcKart2.Text == "20")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (lbPcKart2.Text == "21")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (lbPcKart2.Text == "22")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (lbPcKart2.Text == "23")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (lbPcKart2.Text == "24")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (lbPcKart2.Text == "25")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (lbPcKart2.Text == "26")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (lbPcKart2.Text == "27")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (lbPcKart2.Text == "28")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (lbPcKart2.Text == "29")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (lbPcKart2.Text == "30")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (lbPcKart2.Text == "31")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (lbPcKart2.Text == "32")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (lbPcKart2.Text == "33")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (lbPcKart2.Text == "34")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (lbPcKart2.Text == "35")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (lbPcKart2.Text == "36")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (lbPcKart2.Text == "37")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (lbPcKart2.Text == "38")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (lbPcKart2.Text == "39")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (lbPcKart2.Text == "40")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (lbPcKart2.Text == "41")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (lbPcKart2.Text == "42")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (lbPcKart2.Text == "43")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (lbPcKart2.Text == "44")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (lbPcKart2.Text == "45")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (lbPcKart2.Text == "46")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (lbPcKart2.Text == "47")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (lbPcKart2.Text == "48")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (lbPcKart2.Text == "49")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (lbPcKart2.Text == "50")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (lbPcKart2.Text == "51")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (lbPcKart2.Text == "52")
            {
                picPcKart2.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }


            if (lbPcKart3.Text == "1")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (lbPcKart3.Text == "2")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (lbPcKart3.Text == "3")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (lbPcKart3.Text == "4")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (lbPcKart3.Text == "5")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (lbPcKart3.Text == "6")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (lbPcKart3.Text == "7")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (lbPcKart3.Text == "8")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (lbPcKart3.Text == "9")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (lbPcKart3.Text == "10")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (lbPcKart3.Text == "11")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (lbPcKart3.Text == "12")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (lbPcKart3.Text == "13")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (lbPcKart3.Text == "14")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (lbPcKart3.Text == "15")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (lbPcKart3.Text == "16")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (lbPcKart3.Text == "17")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (lbPcKart3.Text == "18")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (lbPcKart3.Text == "19")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (lbPcKart3.Text == "20")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (lbPcKart3.Text == "21")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (lbPcKart3.Text == "22")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (lbPcKart3.Text == "23")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (lbPcKart3.Text == "24")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (lbPcKart3.Text == "25")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (lbPcKart3.Text == "26")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (lbPcKart3.Text == "27")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (lbPcKart3.Text == "28")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (lbPcKart3.Text == "29")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (lbPcKart3.Text == "30")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (lbPcKart3.Text == "31")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (lbPcKart3.Text == "32")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (lbPcKart3.Text == "33")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (lbPcKart3.Text == "34")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (lbPcKart3.Text == "35")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (lbPcKart3.Text == "36")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (lbPcKart3.Text == "37")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (lbPcKart3.Text == "38")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (lbPcKart3.Text == "39")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (lbPcKart3.Text == "40")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (lbPcKart3.Text == "41")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (lbPcKart3.Text == "42")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (lbPcKart3.Text == "43")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (lbPcKart3.Text == "44")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (lbPcKart3.Text == "45")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (lbPcKart3.Text == "46")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (lbPcKart3.Text == "47")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (lbPcKart3.Text == "48")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (lbPcKart3.Text == "49")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (lbPcKart3.Text == "50")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (lbPcKart3.Text == "51")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (lbPcKart3.Text == "52")
            {
                picPcKart3.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }


            if (lbPcKart4.Text == "1")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_As;
            }
            if (lbPcKart4.Text == "2")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_2;
            }
            if (lbPcKart4.Text == "3")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_3;
            }
            if (lbPcKart4.Text == "4")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_4;
            }
            if (lbPcKart4.Text == "5")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_5;
            }
            if (lbPcKart4.Text == "6")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_6;
            }
            if (lbPcKart4.Text == "7")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_7;
            }
            if (lbPcKart4.Text == "8")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_8;
            }
            if (lbPcKart4.Text == "9")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_9;
            }
            if (lbPcKart4.Text == "10")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_10;
            }
            if (lbPcKart4.Text == "11")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_Vale;
            }
            if (lbPcKart4.Text == "12")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_Kiz;
            }
            if (lbPcKart4.Text == "13")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Karo_Papaz;
            }
            if (lbPcKart4.Text == "14")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_As;
            }
            if (lbPcKart4.Text == "15")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_2;
            }
            if (lbPcKart4.Text == "16")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_3;
            }
            if (lbPcKart4.Text == "17")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_4;
            }
            if (lbPcKart4.Text == "18")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_5;
            }
            if (lbPcKart4.Text == "19")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_6;
            }
            if (lbPcKart4.Text == "20")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_7;
            }
            if (lbPcKart4.Text == "21")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_8;
            }
            if (lbPcKart4.Text == "22")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_9;
            }
            if (lbPcKart4.Text == "23")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_10;
            }
            if (lbPcKart4.Text == "24")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_Vale;
            }
            if (lbPcKart4.Text == "25")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_Kiz;
            }
            if (lbPcKart4.Text == "26")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Sinek_Papaz;
            }
            if (lbPcKart4.Text == "27")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_As;
            }
            if (lbPcKart4.Text == "28")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_2;
            }
            if (lbPcKart4.Text == "29")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_3;
            }
            if (lbPcKart4.Text == "30")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_4;
            }
            if (lbPcKart4.Text == "31")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_5;
            }
            if (lbPcKart4.Text == "32")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_6;
            }
            if (lbPcKart4.Text == "33")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_7;
            }
            if (lbPcKart4.Text == "34")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_8;
            }
            if (lbPcKart4.Text == "35")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_9;
            }
            if (lbPcKart4.Text == "36")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_10;
            }
            if (lbPcKart4.Text == "37")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_Vale;
            }
            if (lbPcKart4.Text == "38")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_Kiz;
            }
            if (lbPcKart4.Text == "39")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Kupa_Papaz;
            }
            if (lbPcKart4.Text == "40")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_As;
            }
            if (lbPcKart4.Text == "41")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_2;
            }
            if (lbPcKart4.Text == "42")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_3;
            }
            if (lbPcKart4.Text == "43")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_4;
            }
            if (lbPcKart4.Text == "44")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_5;
            }
            if (lbPcKart4.Text == "45")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_6;
            }
            if (lbPcKart4.Text == "46")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_7;
            }
            if (lbPcKart4.Text == "47")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_8;
            }
            if (lbPcKart4.Text == "48")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_9;
            }
            if (lbPcKart4.Text == "49")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_10;
            }
            if (lbPcKart4.Text == "50")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_Vale;
            }
            if (lbPcKart4.Text == "51")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_Kiz;
            }
            if (lbPcKart4.Text == "52")
            {
                picPcKart4.Image = BlackJackk.Properties.Resources.Maca_Papaz;
            }



        }


      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ToplamOyuncu.Text)> 21) pictureBox3_Click(this.pictureBox3, null);

                pictureBox3.Enabled = true;
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer6.Enabled = true;

          
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            toplam = 0;
            sayiAtaPc();

                toplam = deger[4]+deger[5];
            lbPcKart1.Text = sayilar[4].ToString();
            lbPcKart2.Text = sayilar[5].ToString();
            if ((deger[4] == 10 && deger[5] == 1) || (deger[5] == 1 && deger[4] == 10))
            {
                toplam = 21;
            }
                lbPcToplam.Text = toplam.ToString();
            if (toplam < 16)
            {
                toplam = 0;
                //ses.SoundLocation = Application.StartupPath + "\\Card.waw";
                ses.Play();
                KartDagitPc3();
                lbPcKart3.Text = sayilar[6].ToString();
                toplam = deger[4] + deger[5] + deger[6];
                lbPcToplam.Text = toplam.ToString();
            }
            if (toplam < 16)
            {
                toplam = 0;
                //ses.SoundLocation = Application.StartupPath + "\\Card.wav";
                ses.Play();
                KartDagitPc4();
                lbPcKart4.Text = sayilar[7].ToString();
                toplam = deger[4] + deger[5] + deger[6] +deger[7]; 
                lbPcToplam.Text = toplam.ToString();

            }
            pcKartCek();
                hesapla();
        }
        
        void hesapla()
        {

            int oyuncuToplam = 0, bilgisayarToplam = 0;

            oyuncuToplam = Convert.ToInt32(ToplamOyuncu.Text);
            bilgisayarToplam = Convert.ToInt32(lbPcToplam.Text);

            if (oyuncuToplam > bilgisayarToplam && oyuncuToplam < 21)
            {
                oyuncupuan = oyuncupuan + 10;
                lbOyuncuSkor.Text = oyuncupuan.ToString();
                DialogResult cikti=MessageBox.Show("Tebrikler 10 puan sizin.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
            if (oyuncuToplam > bilgisayarToplam && oyuncuToplam == 21)
            {
                oyuncupuan = oyuncupuan + 15;
                lbOyuncuSkor.Text = oyuncupuan.ToString();
                ses2.SoundLocation = Application.StartupPath + "\\Alkis.wav";
                ses2.Play();
                DialogResult cikti=MessageBox.Show("BlackJack!!! Tebrikler 15 puan kazandınız.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
            if (bilgisayarToplam > oyuncuToplam && bilgisayarToplam < 21)
            {
                bilgisayarpuan = bilgisayarpuan + 10;
                lbBilgisayarSkor.Text = bilgisayarpuan.ToString();
                DialogResult cikti=MessageBox.Show("10 Puan Masanın.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
            if (bilgisayarToplam > oyuncuToplam && bilgisayarToplam == 21)
            {
                bilgisayarpuan = bilgisayarpuan + 15;
                lbBilgisayarSkor.Text = bilgisayarpuan.ToString();
                ses3.SoundLocation = Application.StartupPath + "\\Ooh.wav";
                ses3.Play();
                DialogResult cikti=MessageBox.Show("BlackJack!!! 15 puan masanın.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
            if (bilgisayarToplam > 21 && oyuncuToplam > 21)
            {
                DialogResult cikti = MessageBox.Show("Kazanan Yok!","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
            if (bilgisayarToplam == oyuncuToplam && bilgisayarToplam <= 21 && oyuncuToplam <= 21)
            {
                DialogResult cikti=MessageBox.Show("Berabere!","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }

            if (bilgisayarToplam < 21 && oyuncuToplam > 21)
            {
                bilgisayarpuan = bilgisayarpuan + 10;
                lbBilgisayarSkor.Text = bilgisayarpuan.ToString();
                DialogResult cikti=MessageBox.Show("10 Puan Masanın.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
            if (bilgisayarToplam == 21 && oyuncuToplam > 21)
            {
                bilgisayarpuan = bilgisayarpuan + 15;
                lbBilgisayarSkor.Text = bilgisayarpuan.ToString();
                ses3.SoundLocation = Application.StartupPath + "\\Ooh.wav";
                ses3.Play();
                DialogResult cikti=MessageBox.Show("BlackJack!!! Puan Masanın.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }
            if (oyuncuToplam < 21 && bilgisayarToplam > 21)
            {
                oyuncupuan = oyuncupuan + 10;
                lbOyuncuSkor.Text = oyuncupuan.ToString();
                DialogResult cikti=MessageBox.Show("Tebrikler 10 puan sizin.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }

            if (oyuncuToplam == 21 && bilgisayarToplam > 21)
            {
                oyuncupuan = oyuncupuan + 15;
                lbOyuncuSkor.Text = oyuncupuan.ToString();
                ses2.SoundLocation = Application.StartupPath + "\\Alkis.wav";
                ses2.Play();
                DialogResult cikti=MessageBox.Show("BlackJack!!! Tebrikler! 15 Puan Kazandınız.","Puan",MessageBoxButtons.OK);
                if (cikti == DialogResult.OK)
                {
                    YeniOyun();
                }
            }

            if (Convert.ToInt32(lbOyuncuSkor.Text) >= 49)
            {
                ses.SoundLocation = Application.StartupPath + "\\fireworks.wav";
                ses.Play();
                pictureBox4.BringToFront();
                pictureBox4.Visible = true;
                DialogResult cevap = MessageBox.Show("Tebrikler Kazandınız.", "Yeni Oyuna Geçmek İster misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    oyuncupuan = 0;
                    bilgisayarpuan = 0;
                    lbBilgisayarSkor.Text = "0";
                    lbOyuncuSkor.Text = "0";
                    pictureBox4.Visible = false;
                }

                else
                {
                    MessageBox.Show("Oyundan Çıkılıyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }

            }
            if (Convert.ToInt32(lbBilgisayarSkor.Text) >= 49)
            {

                DialogResult cevap = MessageBox.Show("Kaybettiniz.", "Yeni Oyuna Geçmek İster misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {
                    oyuncupuan = 0;
                    bilgisayarpuan = 0;
                    lbBilgisayarSkor.Text = "0";
                    lbOyuncuSkor.Text = "0";
                }

                else
                {
                    MessageBox.Show("Oyundan Çıkılıyor!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }

            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
           //Konum belirlemek üzere
           // Point point = this.PointToClient(Cursor.Position);
           // MessageBox.Show(point.ToString());
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ToplamOyuncu.Text) == 0)
            {
                

                KartDagitPc1();
                KartDagitPc2();
            }

        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = BlackJackk.Properties.Resources.YeniOyun2;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = BlackJackk.Properties.Resources.YeniOyun;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult yOyun=MessageBox.Show("Yeni oyuna geçmek istediğinizden emin misini?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (yOyun == DialogResult.Yes)
            {
                lbOyuncuSkor.Text = "0";
                lbBilgisayarSkor.Text = "0";
                sayac = 0;
                sayac2 = 0;
                oyuncupuan = 0;
                bilgisayarpuan = 0;

                toplam = 0;
                lbPcToplam.Text = "0";
                ToplamOyuncu.Text = "0";
                YeniOyun();
            }
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox7.SendToBack();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox7.BringToFront();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kartCek();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            kartCek2();
        }

    }
}
