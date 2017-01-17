using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrock_Click(object sender, EventArgs e)
        {
            string str = "rock";
            PlayGame(str);
        }

        private void PlayGame(string str)
        {
            label2.Text = str;
            Player player = new Player();
            int playerNumber = player.ShowFist(str);

            Computer cpu = new Computer();
            int cpuNumber = cpu.ShowFist();
            label4.Text = cpu.Fist;

            Result res = Ref.Judge(playerNumber, cpuNumber);
            label6.Text = res.ToString();
        }

        private void btnscissor_Click(object sender, EventArgs e)
        {
            string str = "scissor";
            PlayGame(str);
        }


        private void btnpaper_Click_1(object sender, EventArgs e)
        {
            string str = "paper";
            PlayGame(str);
        }
    }
}
