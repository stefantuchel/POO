using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VoicuStefanProiect
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }

        private void PopupForm_Load(object sender, EventArgs e)
        {
            Bitmap bm = Form1.bm2;
           double  red=0, green=0, blue=0;
            for(int i=0;i<bm.Width;i++)
            {
                for(int j=0;j<bm.Height;j++)
                {
                    Color cd = bm.GetPixel(i, j);
                     red += cd.R;
                    green += cd.G;
                     blue += cd.B;
                }

            }
            double redp = red / (900.0*900.0*255.0);
            double greenp = green / (900*900*255);
            double bluep = blue / (900*900*255);
            double K;
            K = Math.Round(1 - max(max(redp, greenp), bluep),1);
            label12.Text = Convert.ToString(K) + "ml";
            double C = Math.Round((1 - redp - K) / (1 - K),1);
            double M = Math.Round((1 - greenp - K) / (1 - K),1);
            double Y = Math.Round((1 - bluep - K) / (1 - K),1);
            label13.Text= Convert.ToString(Y) + "ml";
            label11.Text = Convert.ToString(M) + "ml";
            label10.Text = Convert.ToString(C) + "ml";
            textBox3.Text = Convert.ToString(Math.Round(Y + M + C + K,2)) + "ml";
        }

        double max(double a,double b)
        {
            if (a > b) return a;
            else return b;
        }
        private void label13_Click(object sender, EventArgs e)
        {
           
        }
    }
}
