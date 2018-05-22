using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_HareketiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Bolge[,] bolgeler;
        int sayac = 0;
        int satır = 0, sutun = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.AutoSize = true;
            label1.Visible = false;
            label2.Visible = false;
        }


        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satır = 7; sutun = 7; sayac = 0;
            panel1.Controls.Clear();
            panel1.Enabled = true;
            label2.Text = "0";
            Rectangle r = panel1.ClientRectangle;
            Point p = new Point(r.X, r.Y);

            bolgeler = new Bolge[satır, sutun];
            for (int i = 0; i < satır; i++)         //Bölgeler panele yerleştiriliyor.
            {
                for (int j = 0; j < sutun; j++)
                {
                    bolgeler[i, j] = new Bolge(p, i, j);
                    panel1.Controls.Add(bolgeler[i, j]);
                    bolgeler[i, j].MouseDown += Bolge_Click;
                    p.X += 30;
                }
                p.Y += 30;
                p.X = r.X;
            }
            label1.Text = "";
            label1.Visible = true;
            label1.Location = new Point(p.X + 42, p.Y + 110);
        }
        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satır = 8; sutun = 8; sayac = 0;
            panel1.Controls.Clear();
            panel1.Enabled = true;
            label2.Text = "0";
            Rectangle r = panel1.ClientRectangle;
            Point p = new Point(r.X, r.Y);

            bolgeler = new Bolge[satır, sutun];
            for (int i = 0; i < satır; i++)         //Bölgeler panele yerleştiriliyor.
            {
                for (int j = 0; j < sutun; j++)
                {
                    bolgeler[i, j] = new Bolge(p, i, j);
                    panel1.Controls.Add(bolgeler[i, j]);
                    bolgeler[i, j].MouseDown += Bolge_Click;
                    p.X += 30;
                }
                p.Y += 30;
                p.X = r.X;
            }
            label1.Text = "";
            label1.Visible = true;
            label1.Location = new Point(p.X + 42, p.Y + 110);
        }

        private void x9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            satır = 9; sutun = 9; sayac = 0;
            panel1.Controls.Clear();
            panel1.Enabled = true;
            label2.Text = "0";
            Rectangle r = panel1.ClientRectangle;
            Point p = new Point(r.X, r.Y);

            bolgeler = new Bolge[satır, sutun];
            for (int i = 0; i < satır; i++)         //Bölgeler panele yerleştiriliyor.
            {
                for (int j = 0; j < sutun; j++)
                {
                    bolgeler[i, j] = new Bolge(p, i, j);
                    panel1.Controls.Add(bolgeler[i, j]);
                    bolgeler[i, j].MouseDown += Bolge_Click;
                    p.X += 30;
                }
                p.Y += 30;
                p.X = r.X;
            }
            label1.Text = "";
            label1.Visible = true;
            label1.Location = new Point(p.X + 42, p.Y + 110);
        }
        private void Bolge_Click(object sender, MouseEventArgs e)        //Butonlara Tıklandığında...
        {
            sayac++;
            Bolge bolge = (Bolge)sender;
            bolge.Text = sayac.ToString();
            bolge.Enabled = false;
            label2.Text = sayac.ToString();
            label2.Visible = true;

            int X = bolge.KoordinatX;           //Bolgenin
            int Y = bolge.KoordinatY;           //Koordinatları
            int bolgeSayisi = 0;

            for (int i = 0; i < satır; i++)     //Bir butona tıklandığında diğer bütün butonlar pasif oluyor.
            {
                for (int j = 0; j < sutun; j++)
                {
                    bolgeler[i, j].Enabled = false;
                    bolgeler[i, j].BackColor = Color.White;
                }
            }
            
            //L hareketi için gerekli kontroller yapılıyor
            if (X <= satır - 3)                 
            {
                if (Y <= sutun - 2)
                {
                    bolgeler[X + 2, Y + 1].Enabled = true;
                    bolgeler[X + 2, Y + 1].BackColor = Color.LightCoral;
                }
                if (Y >= 1)
                {
                    bolgeler[X + 2, Y - 1].Enabled = true;
                    bolgeler[X + 2, Y - 1].BackColor = Color.LightCoral;
                }
            }
            if (X <= satır - 2)
            {
                if (Y <= sutun - 3)
                {
                    bolgeler[X + 1, Y + 2].Enabled = true;
                    bolgeler[X + 1, Y + 2].BackColor = Color.LightCoral;
                }
                if (Y >= 2)
                {
                    bolgeler[X + 1, Y - 2].Enabled = true;
                    bolgeler[X + 1, Y - 2].BackColor = Color.LightCoral;
                }
            }
            if (X >= 1)
            {
                if (Y <= sutun - 3)
                {
                    bolgeler[X - 1, Y + 2].Enabled = true;
                    bolgeler[X - 1, Y + 2].BackColor = Color.LightCoral;
                }
                if (Y >= 2)
                {
                    bolgeler[X - 1, Y - 2].Enabled = true;
                    bolgeler[X - 1, Y - 2].BackColor = Color.LightCoral;
                }
            }
            if (X >= 2)
            {
                if (Y <= sutun - 2)
                {
                    bolgeler[X - 2, Y + 1].Enabled = true;
                    bolgeler[X - 2, Y + 1].BackColor = Color.LightCoral;
                }
                if (Y >= 1)
                {
                    bolgeler[X - 2, Y - 1].Enabled = true;
                    bolgeler[X - 2, Y - 1].BackColor = Color.LightCoral;
                }
            }

            for (int i = 0; i < satır; i++)             
            {
                for (int j = 0; j < sutun; j++)
                {
                    if (!(bolgeler[i, j].Text == ""))       //Tıklanılan butonun bir daha tıklanmaması için.
                    {
                        bolgeler[i, j].Enabled = false;
                        bolgeler[i, j].BackColor = Color.White;
                    }
                    if (bolgeler[i, j].Enabled)             //Hamle sayısı bulmak için.
                        bolgeSayisi++;
                }
            }

            label1.Text = "Hamle yapılabilecek " + bolgeSayisi + " bölge vardır.";

            if (sayac == (satır * sutun))
            {
                MessageBox.Show("Tebrikler Kazandınız!!!");
                panel1.Enabled = false;
                label1.Text = "Oyun Bitti. Kazandınız.";
            }
            else if(bolgeSayisi==0)
            {
                MessageBox.Show("Maalesef Kaybettiniz!!!");
                panel1.Enabled = false;
                label1.Text = "Oyun Bitti. Kaybettiniz.";
            }  
        }
    }
}

