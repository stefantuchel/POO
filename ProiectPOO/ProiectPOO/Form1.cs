using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoicuStefanProiect
{
    public partial class Form1 : Form
    {
        public static Bitmap bm2;
        public static Graphics g2;
        Bitmap bm;
        Graphics g;
        ColorDialog cd = new ColorDialog();
        Color new_colr;
      //  Point px, py;
        Pen p = new Pen(Brushes.Black);
        String What;
        int index = 0;
       // int x, y, sX, sY, cX, cY;
        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 900;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void COL_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_colr = cd.Color;
            p.Color = cd.Color;

        }

        private void Printy_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void GoGO_Click(object sender, EventArgs e)
        {
            if (Nr_fig.Text == "") Nr_fig.Text = "0";
            Random r = new Random();
            int caz = 0;
            if (Fig_pick.Text == "Linie") caz = 1;
            if (Fig_pick.Text == "Triunghi") caz = 2;
            if (Fig_pick.Text == "Dreptunghi") caz = 3;
            if (Fig_pick.Text == "Elipsa") caz = 4;
            if (Fig_pick.Text == "Curba Brazier") caz = 5;
            switch (caz)
            {
                case 1:
                    Linie b;
                    for (int i = 0; i < Convert.ToInt32(Nr_fig.Text); i++)
                    {
                        int z = r.Next(100);
                        if (z % 4 == 0)
                        {
                            b = new Linie(new Point(0, r.Next(pic.Height)), new Point(r.Next(pic.Width), 0), p);
                        }
                        else if(z%4==1)
                        {
                            b = new Linie(new Point(pic.Width, r.Next(pic.Height)), new Point(r.Next(pic.Width), pic.Height), p);
                        }
                        else if(z%4==2)
                        {
                            b = new Linie(new Point(r.Next(pic.Width),0), new Point(r.Next(pic.Width), pic.Height), p);
                        }
                        else
                        {
                            b = new Linie(new Point(pic.Width, r.Next(pic.Height)), new Point(0, r.Next(pic.Height)), p);
                        }
                        b.deseneaza(g);
                    }
                    break;
                case 2:
                    Triunghi c;
                    for (int i = 0; i < Convert.ToInt32(Nr_fig.Text); i++)
                    {
                        c = new Triunghi(new Point(r.Next(pic.Width), r.Next(pic.Height)), new Point(r.Next(pic.Width), r.Next(pic.Height)), new Point(r.Next(pic.Width), r.Next(pic.Height)), p);
                        c.deseneaza(g);
                    }
                    break;
                case 3:
                    Dreptungi d;
                    for (int i = 0; i < Convert.ToInt32(Nr_fig.Text); i++)
                    {
                        d = new Dreptungi(new Rectangle(r.Next(pic.Width), r.Next(pic.Height), r.Next(pic.Width), r.Next(pic.Height)), p);
                        d.deseneaza(g);
                    }
                    break;
                case 4:
                    Elipsa f;
                    for (int i = 0; i < Convert.ToInt32(Nr_fig.Text); i++)
                    {
                        f = new Elipsa(new Rectangle(r.Next(pic.Width), r.Next(pic.Height), r.Next(pic.Width), r.Next(pic.Height)), p);
                        f.deseneaza(g);
                    }
                    break;
                case 5:
                    CurbaB h;
                    for (int i = 0; i < Convert.ToInt32(Nr_fig.Text); i++)
                    {

                        h = new CurbaB(new Point(r.Next(pic.Width), r.Next(pic.Height)), new Point(r.Next(pic.Width), r.Next(pic.Height)), new Point(r.Next(pic.Width), r.Next(pic.Height)), new Point(r.Next(pic.Width), r.Next(pic.Height)), p);
                        h.deseneaza(g);
                    }
                    break;
                case 0: break;

            }
            pic.Refresh();
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            //cX = e.X;
            //cY = e.Y;
        }

        private void Fig_pick_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Project_Click(object sender, EventArgs e)
        {


            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }
        private void valideaza(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }


        }
        //static Point set_point(PictureBox pb,Point pt)
        //{
        //   // float pX=
        //}
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    valideaza(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    valideaza(bm, pixel, pt.X + 1, pt.Y , old_color, new_clr);
                    valideaza(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    valideaza(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 1)
            {
                Point point = new Point() ;
                point.X = e.X;
                point.Y = e.Y;
                Fill(bm, point.X, point.Y, new_colr);
                pic.Refresh();
            }
        }

        private void Filly_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                index = 1;
                Filly.BackColor = Color.Black;
            }
            else
            {
                index = 0;
                Filly.BackColor = Color.White;
            }

        }

        private void Savey_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Salvati Imagine ca";
            saveFileDialog1.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
            String Name = "sah" + DateTime.Now.Ticks.ToString();
            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    saveFileDialog1.FileName = Name + ".jpeg";
                    saveFileDialog1.DefaultExt = "*jpeg";
                    bm.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case 2:
                    saveFileDialog1.FileName = Name + ".bmp";
                    saveFileDialog1.DefaultExt = "*bmp";
                    bm.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case 3:
                    saveFileDialog1.FileName = Name + ".gif";
                    saveFileDialog1.DefaultExt = "*gif";
                    bm.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
            }
        }

        private void Infoy_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            bm2 = bm;
            g2 = g;
            PopupForm popup = new PopupForm();
             popup.ShowDialog();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
            
        }
        public class Form2
        {
           
        }
    }
}
