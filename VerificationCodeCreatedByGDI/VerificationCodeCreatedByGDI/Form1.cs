using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificationCodeCreatedByGDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
       
        }
        /// <summary>
        /// create verification code in Picture Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            string str = null;
            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            //create a graphic image in the picture box
            Bitmap bmp = new Bitmap(150, 40);
            Graphics g = Graphics.FromImage(bmp);
            //randomly create five numbers
            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i *20, 0);
                //randomly choose fonts family
                string[]fonts={"Calibri","Arial","Batang","Cambria"};
                //randomly choose colors family
                Color[]colors={Color.AliceBlue,Color.Aqua,Color.Black,Color.Chocolate};
            g.DrawString(str[i].ToString(),new Font(fonts[r.Next(0,4)],15,FontStyle.Bold),new SolidBrush(colors[r.Next(0,4)]),p);
            }
            //randomly draw lines in limited area of picturebox
            for (int i = 0; i < 20; i++)
            {
                Point p1 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                Point p2 = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }
            //create pixels
            for (int i = 0; i < 500; i++)
            {
                Point p = new Point(r.Next(0, bmp.Width), r.Next(0, bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }
                pictureBox1.Image = bmp;

        }
    }
}
