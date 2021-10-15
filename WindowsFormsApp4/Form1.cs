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
        SolidBrush b1 = new SolidBrush(Color.Black);   //primary color
        SolidBrush b2 = new SolidBrush(Color.White);   //secondary color
        Pen p1 = new Pen(Color.Black);

        Prim currentPrim;

        List<Point> plist = new List<Point>();

        enum primitiveType
        {
            point, segment, polygon
        }

        struct Prim
        {
            public Prim(primitiveType t, List<Point> p)
            {
                type = t;
                points = p;
            }

            primitiveType type { get; }
            List<Point> points { get; }
            //int[][] matrix;
        }

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

        private void disableRadios()
        {
            radioPoint.Enabled = false;
            radioRectangle.Enabled = false;
            radioSegment.Enabled = false;
        }

        private void enableRadios()
        {
            radioPoint.Enabled = true;
            radioRectangle.Enabled = true;
            radioSegment.Enabled = true;
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
            if (radioPoint.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.FillEllipse(b1, e.X - 2, e.Y - 2, 5, 5);
                }
                else
                {
                    g.FillEllipse(b2, e.X - 2, e.Y - 2, 5, 5);
                }

                disableRadios();
                radioPoint.Checked = false;

                panel5.Enabled = true;
                textBox1.Text = "Point";
            }


            //POLYGON DRAWING
            if (radioRectangle.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point newPoint = new Point(e.X, e.Y);
                    if (plist.Count != 0)
                    {
                        g.DrawLine(p1, plist.Last(), newPoint);
                    }
                    plist.Add(newPoint);
                }
                if (e.Button == MouseButtons.Right)
                {
                    if (plist.Count != 0)
                    {
                        Point newPoint = new Point(e.X, e.Y);
                        g.DrawLine(p1, plist.Last(), newPoint);
                        g.DrawLine(p1, plist.First(), newPoint);
                        plist.Add(newPoint);
                    }

                    disableRadios();
                    radioRectangle.Checked = false;

                    panel5.Enabled = true;
                    textBox1.Text = "Polygon";
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            enableRadios();
            radioPoint.Checked = true;
            panel5.Enabled = false;
        }
    }
}
