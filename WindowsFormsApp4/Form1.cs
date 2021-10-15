using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Graphics g;
        //List<Point> primitives; //###TODO: stack of primitives on canvas
        SolidBrush b1 = new SolidBrush(Color.Black);   //primary color
        SolidBrush b2 = new SolidBrush(Color.White);   //secondary color

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                b1.Color = cd.Color;
                panel3.BackColor = cd.Color;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                b2.Color = cd.Color;
                panel4.BackColor = cd.Color;
            }
        }



        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
             //TODO: POINT DRAWING
            if (radioPoint.Checked) {
                if (e.Button == MouseButtons.Left)
                {
                    g.FillEllipse(b1, e.X-2, e.Y-2, 5, 5);

                }
                else
                {
                    g.FillEllipse(b2, e.X-2, e.Y-2, 5, 5);
                }
                xb = e.X;
                yb = e.Y;
            }

            if (radioSegment.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    setPosition(e.X, e.Y, b1.Color);

                }
                else
                {
                    setPosition(e.X, e.Y, b2.Color);
                }
            }



            /* ###TODO: RECTANGLE DRAWING
             */
        }

        private int? x0, y0;
        private int? x1, y1;
        private int? xb, yb;

        public void setPosition(int x, int y, Color color)
        {

            if (x0 == null || y0 == null)
            {
                x0 = x;
                y0 = y;
                return;
            }
            if (x1 == null || y1 == null)
            {
                x1 = x;
                y1 = y;
                drawWuLine2(x0.GetValueOrDefault(), y0.GetValueOrDefault(), x1.GetValueOrDefault(), y1.GetValueOrDefault(), color);
                //rotatePixels(90);
                //pointDirection(x0.GetValueOrDefault(), y0.GetValueOrDefault(),x1.GetValueOrDefault(),y1.GetValueOrDefault(), xb.GetValueOrDefault(), yb.GetValueOrDefault());
                return;
            }
            x0 = x;
            y0 = y;
            x1 = null;
            y1 = null;
        }

        void drawPixel(int x, int y, double c, Color color)
        {
            Brush brush = new SolidBrush(Color.FromArgb((int)c, color));
            g.FillRectangle(brush, x, y, 1, 1);
        }

        void rotatePixels(double alpha)
        {
            var radians = alpha * Math.PI / 180;

            var mid_x = (x0 + x1) / 2;

            var mid_y = (y0 + y1) / 2;

            var a_mid_x = x0 - mid_x;
            var a_mid_y = y0 - mid_y;

            var b_mid_x = x1 - mid_x;
            var b_mid_y = y1 - mid_y;

            var a_rotated_x =
        Math.Cos(radians) * a_mid_x - Math.Sin(radians) * a_mid_y;
            var a_rotated_y =
        Math.Sin(radians) * a_mid_x + Math.Cos(radians) * a_mid_y;

            var b_rotated_x =
        Math.Cos(radians) * b_mid_x - Math.Sin(radians) * b_mid_y;
            var b_rotated_y =
        Math.Sin(radians) * b_mid_x + Math.Cos(radians) * b_mid_y;

            a_rotated_x += mid_x;
            a_rotated_y += mid_y;
            b_rotated_x += mid_x;
            b_rotated_y += mid_y;

            drawWuLine2(int.Parse(Math.Floor(a_rotated_x.GetValueOrDefault()).ToString()), int.Parse(Math.Floor(a_rotated_y.GetValueOrDefault()).ToString()), int.Parse(Math.Floor(b_rotated_x.GetValueOrDefault()).ToString()), int.Parse(Math.Floor(b_rotated_y.GetValueOrDefault()).ToString()), Color.Red);
        }

        void pointDirection(int beginX0,int beginY0, int beginX1, int beginY1, int pointX,int pointY)
        {
            beginX1 -= beginX0;
            beginY1 -= beginY0;
            pointX -= beginX0;
            pointY -= beginY0;

            int cond = beginX1 * pointY - beginY1 * pointX;
            if (cond > 0)
            {
                Console.WriteLine("Точка расположена справа");
            } else if (cond < 0)
            {
                Console.WriteLine("Точка расположена слева");
            }
        }

        




        void drawWuLine2(int x0, int y0, int x1, int y1, Color color)
        {

                g.FillEllipse(b1, x0 - 2, y0 - 2, 5, 5);
           

            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                (x0, y0) = (y0, x0);
                (x1, y1) = (y1, x1);
            }
            if (x0 > x1)
            {
                (x0, x1) = (x1, x0);
                (y0, y1) = (y1, y0);
            }

            double dx = x1 - x0;
            double dy = y1 - y0;
            double gradient = (double)((double)(dy) / (double)(dx));
            if (dx == 0.0)
            {
                gradient = 1;
            }

            int xpxl1 = x0;
            int xpxl2 = x1;
            double intery = y0;

            if (steep)
            {
                for (int x = int.Parse((xpxl1).ToString()); x <= int.Parse((xpxl2).ToString()); x++)
                {
                    
                    
                        drawPixel(int.Parse(iPart(intery).ToString()), int.Parse(x.ToString()), rfPart(intery) * 255, color);
                        drawPixel(int.Parse(iPart(intery).ToString()) + 1, int.Parse(x.ToString()), fPart(intery) * 255, color);
                        intery += gradient;
                    
                    
                }
            }
            else
            {
                for (int x = int.Parse((xpxl1).ToString()); x <= int.Parse((xpxl2).ToString()); x++)
                {
                    drawPixel(int.Parse(x.ToString()), int.Parse(iPart(intery).ToString()), rfPart(intery) * 255, color);
                    drawPixel(int.Parse(x.ToString()), int.Parse(iPart(intery).ToString()) + 1, fPart(intery) * 255, color);
                    intery += gradient;
                }
            }
        }

        int iPart(double d)
        {
            return (int)d;
        }

        int round(double d)
        {
            return (int)(d + 0.50000);
        }

        double fPart(double d)
        {
            return (double)(d - (int)(d));
        }

        double rfPart(double d)
        {
            return (double)(1.00000 - (double)(d - (int)(d)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            (x0, y0, x1, y1, xb, yb) = (null, null, null, null, null, null);
    }
    }
}
