using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //store music files' full path
        List<string>listSongs=new List<string>();
        /// <summary>
        /// Open music files by browsing local files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose music";
            ofd.InitialDirectory = @"C:\Users\qtt1563\Desktop";
            ofd.Multiselect = true;
            ofd.Filter = "musicfiles|*.wav|allfiles|*.*";
            ofd.ShowDialog();
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path[i]));
                listSongs.Add(path[i]);
            }
        }
        /// <summary>
        /// double click to play music in listbox
        /// </summary>
        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
          
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();

        }
        /// <summary>
        /// play preivous music file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            //if user wants to play the previous song of the first song, it can skip to the last one 
            if (index <0)
            { index = listBox1.Items.Count-1; }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
        /// <summary>
        /// play next music file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            //if user wants to play the next song of the last song, it can skip to the first one 
            if (index == listBox1.Items.Count)
            { index = 0; }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
    }
}
