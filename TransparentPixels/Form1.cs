using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransparentPixels
{
    public partial class Form1 : Form
    {
        
        private Rectangle Trojka, Dvojka;
        private Point[] El, Ge;
        Rectangle cube = new Rectangle(600,25,200, 200);
        Rectangle trojka = new Rectangle(750, 475, 300, 100);
        Rectangle dvojka = new Rectangle(900, 250, 100, 200);

        bool isMouseDown = false;
        bool cubeSelected = false;
        bool trojkaSelected = false;
        bool dvojkaSelected = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.DarkGray, 5);
            SolidBrush cetka1 = new SolidBrush(Color.DodgerBlue);
            SolidBrush cetka2 = new SolidBrush(Color.Orange);
            SolidBrush cetka3 = new SolidBrush(Color.GreenYellow);
            SolidBrush cetka4 = new SolidBrush(Color.ForestGreen);
            SolidBrush cetka5 = new SolidBrush(Color.DarkOrchid);
            
            Ge = new Point[] { new Point(600,250), new Point(800,250),
                               new Point(800,350), new Point(700,350),
                               new Point(700,550), new Point(600,550) };
            El = new Point[] { new Point(850,25), new Point(950,25),
                               new Point(950,125), new Point(1050,125),
                               new Point(1050,225),new Point(850,225)};
            //Trojka = new Rectangle(750, 475, 300, 100);
            //Dvojka = new Rectangle(900, 250, 100, 200);

            e.Graphics.DrawLine(myPen, 100, 100, 100, 500);
            e.Graphics.DrawLine(myPen, 200, 100, 200, 500);
            e.Graphics.DrawLine(myPen, 300, 100, 300, 500);
            e.Graphics.DrawLine(myPen, 400, 100, 400, 500);
            e.Graphics.DrawLine(myPen, 500, 100, 500, 500);

            e.Graphics.DrawLine(myPen, 100, 100, 500, 100);
            e.Graphics.DrawLine(myPen, 100, 200, 500, 200);
            e.Graphics.DrawLine(myPen, 100, 300, 500, 300);
            e.Graphics.DrawLine(myPen, 100, 400, 500, 400);
            e.Graphics.DrawLine(myPen, 100, 500, 500, 500);

            e.Graphics.FillRectangle(cetka1, cube);
            e.Graphics.FillPolygon(cetka2, Ge);
            e.Graphics.FillPolygon(cetka3, El);
            e.Graphics.FillRectangle(cetka4, trojka);
            e.Graphics.FillRectangle(cetka5, dvojka);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (cubeSelected == true)
            {
                
                if (isMouseDown == true)
                {
                    cube.Location = e.Location;

                    if (cube.Right > panel1.Width)
                    {
                        cube.X = panel1.Width - cube.Width;
                    }
                    if (cube.Top < 0)
                    {
                        cube.Y = 0;
                    }
                    if (cube.Left < 0)
                    {
                        cube.X = 0;
                    }
                    if (cube.Bottom > panel1.Height)
                    {
                        cube.Y = panel1.Height - cube.Height;
                    }
                    Refresh();
                }

            }
            if (dvojkaSelected == true)
            {
                
                if (isMouseDown == true)
                {
                    dvojka.Location = e.Location;
                    
                    if (dvojka.Right > panel1.Width)
                    {
                        dvojka.X = panel1.Width - dvojka.Width;
                    }
                    if (dvojka.Top < 0)
                    {
                        dvojka.Y = 0;
                    }
                    if (dvojka.Left < 0)
                    {
                        dvojka.X = 0;
                    }
                    if (dvojka.Bottom > panel1.Height)
                    {
                        dvojka.Y = panel1.Height - dvojka.Height;
                    }
                    Refresh();
                }
                else
                {
                    cubeSelected = false;
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            //cubeSelected = false;
            //dvojkaSelected = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            cubeSelected = true;
            dvojkaSelected = true;
        }
    }
}
