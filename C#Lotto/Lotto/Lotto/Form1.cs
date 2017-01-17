using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool b used to be set up for playing and pausing
            if (b == false)
            {
                b = true;
                button1.Text = "stop";
            //create a thread to not freeze the winform
                Thread th = new Thread(PlayGame);
                th.IsBackground = true;
                th.Start();
            }
            else {
                b = false;
                button1.Text = "start";
            }
           
        }
        bool b = false;
        private void PlayGame() {
            Random r = new Random();
            while (b) {
                label1.Text = r.Next(0, 10).ToString();
                label2.Text = r.Next(0, 10).ToString();
                label3.Text = r.Next(0, 10).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //avoid the illegal cross thread calling
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
