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
            }



            /* ###TODO: SEGMENT DRAWING
             */



            /* ###TODO: RECTANGLE DRAWING
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
        }
    }
}
