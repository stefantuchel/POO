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

namespace Proiect_2
{
    public partial class Form1 : Form
    {
        int col;
        int cuvinte;
        int maxCuv;
        int minCuv;
        int timp;
        Image img;
        Graphics g;

        List<Cuvant> RO;
        List<Cuvant> EN;
        List<Cuvant> rez = new List<Cuvant>();
        class Cuvant
        {
            String text;
            int id;
            public Cuvant(String text, int id)
            {
                this.text = text;
                this.id = id;
            }

            public String Text
            {
                get { return text; }
                set { this.text = value; }
            }
            public int Id
            {
                get { return id; }
                set { this.id = value; }
            }
            public static List<Cuvant> citeste_cuvinte(String nume_fisier)
            {
                List<Cuvant> lista = new List<Cuvant>();
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(nume_fisier, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    for (; ; )
                    {
                        String linie = sr.ReadLine();
                        if (linie == null) break;//daca s-a citit tot
                        int index = linie.IndexOf(";");
                        if (index >= 0)
                        {
                            String temp_text = linie.Substring(1, index - 2);
                            linie = linie.Substring(index + 1);
                            try
                            {
                                lista.Add(new Cuvant(temp_text, Convert.ToInt32(linie)));
                            }
                            catch (Exception) { };
                        }
                    }
                }
                catch (System.Exception) { }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
                return lista;
            }
        };

        void citeste_cuvinte()
        {
            RO = Cuvant.citeste_cuvinte("RO.txt");
            EN = Cuvant.citeste_cuvinte("EN.txt");
        }

        void alege_cuvinte(List<Cuvant> A)
        {
            rez.Clear();
            foreach(Cuvant a in A)
            {
                if (a.Text.Length <= maxCuv)
                    if (a.Text.Length >= minCuv)
                    {
                        rez.Add(a);
                    }
            }
        }
        
        void afisare_cuvinte()
        {
            listBox1.Items.Clear();
            Random random = new Random();
            for(int i = 0; i < cuvinte; i++)
            {
                int[] ind = new int[cuvinte];
                ind[i] = random.Next(rez.Count);
                listBox1.Items.Add(rez[ind[i]].Text.ToUpper());
            }
            listBox1.Refresh();
        }
        int[,] caractere;
        void split_cuvinte()
        {
            caractere = new int[15,15];
            carac = new int[15, 15];
            Random random = new Random();
            int index;
            for (int i = 0; i < cuvinte; i++)
            {
                string s = listBox1.Items[i].ToString();
                s = s.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                char[] siruri = s.ToCharArray();//.Where(c=>!Char.IsWhiteSpace(c)).ToArray();
                index = random.Next(0, col - siruri.Length-1);
                for (int j = 0; j < siruri.Length; j++)
                {
                    caractere[i, j] = siruri[j];
                    if (i == 0)
                    {
                        carac[index + j+1, index + j+1] = siruri[j];
                    }
                    if (i == 1)
                    {
                        carac[index + j, col -1] = siruri[j];
                    }
                    if (i == 2)
                    {
                        carac[0, j + index+1] = siruri[j];
                    }
                    if (i == 3)
                    {
                        carac[col-1, j+index+1] = siruri[j];
                    }
                    if (i == 4)
                    {
                        carac[j+index+1, 0] = siruri[j];
                    }
                }
            }
        }
        int[,] carac;

        int l = 40;
        int x = 0;
        int y = 0;
        void deseneaza()
        {
            g.Clear(Color.White);
            Pen creion = new Pen(Color.Black, 2);
            Brush col1 = Brushes.Red;
            for (int i = 1; i < col; i++)
            {
                //g.FillRectangle((i + j) % 2 == 0 ? Culoare : col2, l + i * l, l + j * l, l, l);
                if (i * l < x && x < l + i * l)
                    for (int j = 1; j < col; j++)
                        if (j * l < y && y < l + j * l)
                            g.FillRectangle(col1, i * l, j * l, l, l);
            }
            for (int i = 0; i <= col; i++)
            {
                g.DrawLine(creion, l, l + i * l, (col+1) * l, l + i * l);
                g.DrawLine(creion, l + i * l, l, l + i * l, (col+1) * l);
            }

            //introducerea literelor
            System.Drawing.Font f = new Font("Times New Roman", 12);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            split_cuvinte();
            //carac = caractere;
            Random random = new Random();
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (carac[i, j] == 0)
                    {
                        carac[i, j] = (char)(random.Next(65, 91));
                    }
                    g.DrawString(((char)(carac[i,j])).ToString(), f, Brushes.Black, new RectangleF(l + i * l, l + j * l, l, l), sf);
                }
            }
        }
        void randomizare_cuvinte()
        {
        }
        string[,] v = new string[11,11];
        void randomizare_text()
        {
            Random random = new Random();
            for (int i = 0; i < col - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    v[i, j] = ((char)(random.Next(65, 91))).ToString();
                }
            }
        }

        void config(bool visible)
        {
            label1.Visible = visible;
            label2.Visible = visible;
            label3.Visible = visible;
            label4.Visible = visible;
            label5.Visible = visible;
            label6.Visible = visible;
            nrCol.Visible = visible;
            nrCuv.Visible = visible;
            maxCar.Visible = visible;
            minCar.Visible = visible;
            limba.Visible = visible;
            timpmax.Visible = visible;
            button1.Visible = visible;
            button2.Visible = visible;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            img = new Bitmap(500, 500);
            g = Graphics.FromImage(img);
            citeste_cuvinte();
        }

        private void jocNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (limba.SelectedIndex != -1)
                alege_cuvinte(limba.SelectedIndex == 0 ? RO : EN);
            afisare_cuvinte();
            randomizare_text();
            deseneaza();
            Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configurareJocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                col = Convert.ToInt16(nrCol.Text);
                cuvinte = Convert.ToInt16(nrCuv.Text);
                maxCuv = Convert.ToInt16(maxCar.Text);
                minCuv = Convert.ToInt16(minCar.Text);
                timp = Convert.ToInt16(timpmax.Text);
                if (col > 11) {
                    MessageBox.Show("Numarul introdus este prea mare.Dati o valoare mai mica decat 12!", "Atentie!");
                    col = 0;
                }
                if (col < 5)
                {
                    MessageBox.Show("Numarul introdus trebuie sa fie mai mare decat 4!", "Atentie!");
                    col = 0;
                }
                if (maxCuv > col-2)
                {
                    MessageBox.Show("Numarul de caractere este prea mare!", "Atentie!");
                    col = 0;
                }
                if (minCuv <= 2)
                {
                    MessageBox.Show("Numarul de caractere trebuie sa fie mai mare decat 2!", "Atentie!");
                    col = 0;
                }
                if (cuvinte > 5)
                {
                    MessageBox.Show("Numarul de cuvinte este prea mare.Dati o valoare mai mica decat 6!", "Atentie!");
                    col = 0;
                }
                if (cuvinte <= 1)
                {
                    MessageBox.Show("Numarul de cuvinte trebuie sa fie mai mare decat 1!", "Atentie!");
                    col = 0;
                }
                if (minCuv > maxCuv)
                {
                    MessageBox.Show("Numarul de caractere minime este mai mare decat numarul de caractere maxime!", "Atentie!");
                    col = 0;
                }
                if (timp <= 0)
                {
                    MessageBox.Show("Introduceti un timp pozitiv!", "Atentie!");
                    col = 0;
                }
             }
            catch (Exception)
            {
                MessageBox.Show("Trebuie sa introduceti un numar natural!", "Atentie!");
                col = 0;
            }
            if (limba.SelectedIndex==-1)
            {
                MessageBox.Show("Trebuie sa alegeti o limba!", "Atentie!");
                col = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            deseneaza();
           // pictureBox1.Refresh();
        }
        void selectare_dificultate(int a, int b, int c, int d, int e)
        {
            col = a;
            cuvinte = b;
            maxCuv = c;
            minCuv = d;
            timp = e;
        }
        private void incepatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config(false);
            selectare_dificultate(5, 2, 3, 2, 100);
            alege_cuvinte(RO);
            afisare_cuvinte();
            randomizare_text();
            deseneaza();
            Refresh();
        }

        private void mediuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config(false);
            selectare_dificultate(7, 4, 5, 3, 100);
            alege_cuvinte(RO);
            afisare_cuvinte();
            randomizare_text();
            deseneaza();
            Refresh();
        }

        private void avansatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config(false);
            selectare_dificultate(11, 5, 9, 5, 100);
            alege_cuvinte(RO);
            afisare_cuvinte();
            randomizare_text();
            deseneaza();
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime ora = new DateTime();

            label7.Text = ora.ToLongTimeString();
        }
    }
}
