using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace VoicuStefanProiect
{
    public abstract class Figura
    {
        protected int x1, y1, x2, y2, tip_fig;
        protected Point a, b, c, d;
        protected Rectangle e;
        protected Pen penzy;
        public Figura(Point a, Point b,Pen penzy)
        {
            this.a = a;
            this.b = b;
            tip_fig = 1;
            this.penzy = penzy;
        }
        public Figura(Point a, Point b, Point c,Pen penzy)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            tip_fig = 2;
            this.penzy=penzy;
        }
        public Figura(Rectangle e,Pen penzy)
        {
            this.e = e;
            tip_fig = 3;
            this.penzy = penzy;
        }
        public Figura(Rectangle e,int tip_fig,Pen penzy)
        {
            this.e = e;
            this.tip_fig = 4;
            this.penzy =penzy;
        }
        public Figura(Point a, Point b, Point c,Point d,Pen penzy)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.tip_fig = 5;
            this.penzy = penzy;
        }
        public int X1
        {
            get { return x1; }
            set { this.x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { this.y1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { this.x2 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { this.y2 = value; }
        }

        public Point A
        {
            get { return a; }
            set { a = value; }
        }
        public Point B
        {
            get { return b; }
            set { b = value; }
        }

        public Point C
        {
            get { return c; }
            set { c = value; }
        }

        public Point D
        {
            get { return d; }
            set { d = value; }
        }
        public int TIP_FIG
        {
            get { return tip_fig; }
            set { this.tip_fig = value; }
        }
        public void deseneaza(Graphics g)
        {
            if (tip_fig == 1)
            {
                g.DrawLine(penzy, a, b);
            }
            else if (tip_fig == 2)
            {
                g.DrawLine(penzy, a, b);
                g.DrawLine(penzy, b, c);
                g.DrawLine(penzy, c, a);
            }
            else if(tip_fig==3)
            {
                g.DrawEllipse(penzy, e);
            }
            else if(tip_fig==4)
            {
                g.DrawRectangle(penzy, e);
            }
            else
            {
                g.DrawBezier(penzy, a,b,c,d);
            }
        }
    }
    public class Linie : Figura
    {
        public Linie(Point a, Point b,Pen p) : base(a, b,p)
        {


        }
    }
    public class Triunghi : Figura
    {
        public Triunghi(Point a, Point b, Point c,Pen p) : base(a, b, c,p)
        {


        }
    }
    public class Elipsa : Figura
    {
        public Elipsa(Rectangle a,Pen p) : base(a,p)
        {


        }
    }
    public class Dreptungi : Figura
    {
        public Dreptungi(Rectangle a,Pen p) : base(a,1,p)
        {


        }
    }
    public class CurbaB : Figura
    {
        public CurbaB(Point a, Point b, Point c, Point d,Pen p) : base(a,b,c,d,p)
        {


        }
    }
}