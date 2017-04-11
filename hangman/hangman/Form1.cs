using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace hangman
{

    //we define a class in here.//********************************CLASS******************************************//

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] harfler = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z", "x", "q", "w" };
        Adam_Asmaca_islemleri cl_adam_asmaca;
        string kelime;
        string[] secilen_harfler;
        int can_hakki = 7;
        int kalan_hakkimiz;
        int width, height;

        //**************************************HANGMAN**************************************//
        private void Form1_Load(object sender, EventArgs e)
        {
            konum_ayarla();
            width = pcb_adam.Width;
            height = pcb_adam.Height;
            kalan_hakkimiz = can_hakki;
            secilen_harfler = new string[0];
            cl_adam_asmaca = new Adam_Asmaca_islemleri();
        }

        //**************************************HANGMAN**************************************//
        private void kelimeyi_Sec()
        {
           Adam_Asmaca_islemleri.Yeni_Kelime kelimemiz_ = cl_adam_asmaca.kelime_al();
            lbl_kategori.Text = "Bu bir " + kelimemiz_.kategori;
            kelime = kelimemiz_.kelime;
            foreach (char harf in kelime.ToCharArray())
            {
                lbl_kelime.Text = lbl_kelime.Text + "_ ";
            }
            button1.Visible = false;
        }

        //**************************************HANGMAN**************************************//
        private void button1_Click(object sender, EventArgs e)
        {
            pcb_adam.Visible = true;
            textBox1.Visible = true;
            lbl_soylenenler.Visible = true;
            lbl_kelime.Visible = true;
            lbl_kategori.Visible = true;
            button2.Visible = true;
            kelimeyi_Sec();
        }

        //**************************************HANGMAN**************************************//
        private void button2_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            bool buldu = false;
            bool soylendi = false;
            foreach(var item in secilen_harfler)
            {
                if(veri.ToLower() == item.ToLower())
                {
                    soylendi = true;
                    MessageBox.Show("Bu harfi daha önce söylediniz");
                }
            }
            if (!soylendi)
            {
                for (int i = 0; i < harfler.Length; i++)
                {
                    if (veri.ToLower() == harfler[i])
                    {
                        buldu = true;
                        kelimede_bul(veri);
                        break;
                    }
                }
                if (!buldu)
                {
                    MessageBox.Show("Geçerli bir harf yazınız");
                }
                guncelle();
            }
            int index = lbl_kelime.Text.IndexOf("_");
            if(index == -1)
            {
                sonraki_bolum();
            }
        }

        //**************************************HANGMAN**************************************//
        private void kelimede_bul(string harf)
        {
            bool dogru_mu = false;
            char[] dizi = kelime.ToCharArray();
            for (int a=0; a < dizi.Length; a++)
            {
                if(dizi[a].ToString() != "")
                {
                    if (harf == dizi[a].ToString().ToLower())
                    {
                        dogru_mu = true;
                        lbl_kelime.Text = lbl_kelime.Text.Remove(a * 2, 1);
                        lbl_kelime.Text = lbl_kelime.Text.Insert(a * 2, harf).ToUpper();

                    }
                }
            }
            if (!dogru_mu)
            {
                
                pcb_adam.Invalidate();
                kalan_hakkimiz--;
                
            }
            ekle_harf(harf);
        }

        //**************************************HANGMAN**************************************//
        private void guncelle()
        {
            lbl_soylenenler.Text = "";
            foreach(string item in secilen_harfler)
            {
                lbl_soylenenler.Text = lbl_soylenenler.Text + item + " ";
            }
        }

        //**************************************HANGMAN**************************************//
        private void ekle_harf(string harf)
        {
            string[] a = new string[secilen_harfler.Length + 1];
            for(int i= 0; i < secilen_harfler.Length; i++)
            {
                a[i] = secilen_harfler[i];
            }
            a[a.Length - 1] = harf;
            secilen_harfler = a;
        }

        //**************************************HANGMAN**************************************//
        private void pcb_adam_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem = new Pen(Color.Black, 12);
            if (kalan_hakkimiz != -1)
            {
                if (kalan_hakkimiz < can_hakki)
                {
                    e.Graphics.DrawLine(kalem, width / 10, height / 15, width / 10, height / 15 * 14);
                    e.Graphics.DrawLine(kalem, width / 10, height / 15, width / 2, height / 15);
                }
                if (kalan_hakkimiz < can_hakki - 1)
                {
                    e.Graphics.DrawLine(kalem, width / 2, height / 15, width / 2, height / 15 * 3);
                    e.Graphics.DrawEllipse(kalem, width / 2 - width / 20, height / 5, width / 10, height / 10);
                }
                if (kalan_hakkimiz < can_hakki - 2)
                {
                    e.Graphics.DrawLine(kalem, width / 2, height / 10 * 3, width / 2, height / 10 * 6);
                }
                if (kalan_hakkimiz < can_hakki - 3)
                {
                    e.Graphics.DrawLine(kalem, width / 2, height / 10 * 3, width / 2 + width / 10, height / 10 * 3 + height / 5);
                }
                if (kalan_hakkimiz < can_hakki - 4)
                {
                    e.Graphics.DrawLine(kalem, width / 2, height / 10 * 3, width / 2 - width / 10, height / 10 * 3 + height / 5);
                }
                if (kalan_hakkimiz < can_hakki - 5)
                {
                    e.Graphics.DrawLine(kalem, width / 2, height / 10 * 6, width / 2 + width / 10, height / 10 * 6 + height / 10);
                }
                if (kalan_hakkimiz < can_hakki - 6)
                {
                    e.Graphics.DrawLine(kalem, width / 2, height / 10 * 6, width / 2 - width / 10, height / 10 * 6 + height / 10);

                }
            }else { oyun_bitti(); }
     

      }

        //**************************************HANGMAN**************************************//
        private void sonraki_bolum()
        {
            temizle();
            kelimeyi_Sec();
        }

        //**************************************HANGMAN**************************************//
        private void oyun_bitti()
        {
            MessageBox.Show("Oyun Bitti. Doğru kelime: "+kelime);
            button1.Visible = true;
            textBox1.Visible = false;
            button2.Visible = false;
            temizle();
            pcb_adam.Visible = false;
        }

        //**************************************HANGMAN**************************************//
        private void temizle()
        {
            secilen_harfler = new string[0];
            kalan_hakkimiz = can_hakki;
            pcb_adam.Invalidate();
            lbl_kategori.Text = "";
            lbl_kelime.Text = "";
            lbl_soylenenler.Text = "";
            textBox1.Text = "";
        }

        //**************************************HANGMAN**************************************//
        private void lbl_soylenenler_Click(object sender, EventArgs e)
        {

        }

        //**************************************HANGMAN**************************************//

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            konum_ayarla();
        }

        //**************************************HANGMAN**************************************//
        public void konum_ayarla()
        {
            int width, height;
            width = this.Width;
            height = this.Height;
            panel1.Width = width;
            panel1.Height = height;
            panel1.Location = new Point(0, 0);
            pcb_adam.Width = width / 9 * 4;
            pcb_adam.Height = height / 4 * 3;
            pcb_adam.Location = new Point(width - pcb_adam.Width - 10,10);
            lbl_kategori.Location = new Point(10, 10);
            lbl_kelime.Location = new Point(10, 50);
            lbl_soylenenler.Location = new Point(10, 120);
            button1.Size = new System.Drawing.Size(width / 3, height / 10);
            textBox1.Location = new Point(10,90);
            button1.Location = new Point(width / 2-button1.Width/2, height / 2-button1.Height/2);
            button2.Location = new Point(70,90);
            lbl_soylenenler.Location = new Point(10, height / 2);
        }

        //**************************************HANGMAN**************************************//
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    //we define a class in here.//********************************CLASS******************************************//
    class Adam_Asmaca_islemleri
    {
        private List<Yeni_Kelime> yeni_kelime_listesi;
        private List<Yeni_Kelime> kelime_liste;
        public Adam_Asmaca_islemleri()
        {
            data_dosyasini_al();
        }
       public struct Yeni_Kelime
        {
            public string kelime;
            public string kategori;
        }
        public Yeni_Kelime kelime_al()
        {
            if (kelime_liste.Count == 0)
            {
                kelime_liste = yeni_kelime_listesi;
            }
            Random rastg = new Random();
            int a = rastg.Next(0, kelime_liste.Count);
            Yeni_Kelime kelimemiz = kelime_liste[a];
            return kelimemiz;
        }
        public Yeni_Kelime Yeni_kelime_olustur(string kelime,string kategori)
        {
            Yeni_Kelime kelimemiz = new Yeni_Kelime();
            kelimemiz.kelime = kelime;
            kelimemiz.kategori = kategori;
                return kelimemiz;
        }
        private void data_dosyasini_al()
        {
            yeni_kelime_listesi = new List<Yeni_Kelime>();
            StreamReader oku = new StreamReader(@"data.txt",Encoding.Default);
            string veri;
            while((veri=oku.ReadLine()) != null)
            {
                if(veri != "")
                {
                    yeni_kelime_listesi.Add(Yeni_kelime_olustur(veri.Split(',')[0], veri.Split(',')[1]));
                }
            }
            kelime_liste = yeni_kelime_listesi;
        }
    }
}
