using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Draw one line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //create gui
            Graphics g = this.CreateGraphics();
            //create pen
            Pen pen = new Pen(Brushes.Yellow);
            //create location of line
            Point p1 = new Point(0, 0);
            Point p2 = new Point(50, 50);
            g.DrawLine(pen,p1,p2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //create gui
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Yellow);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(50, 50);
            g.DrawLine(pen, p1, p2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Yellow);
            Size size = new System.Drawing.Size(80, 80);
            Rectangle rec = new Rectangle(new Point(50, 50),size);
            g.DrawRectangle(pen, rec);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Size size = new System.Drawing.Size(180, 180);
            Rectangle rec = new Rectangle(new Point(150, 150), size);
            g.DrawPie(pen, rec, 60, 60);
        }
    }
}
