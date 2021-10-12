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
        Pen p1 = new Pen(Color.Black);   //primary color
        Pen p2 = new Pen(Color.White);   //secondary color

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p1.Color = cd.Color;
                panel3.BackColor = cd.Color;
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p2.Color = cd.Color;
                panel4.BackColor = cd.Color;
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
