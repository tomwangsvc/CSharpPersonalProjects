using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// defaultly set the panel of opened history to close 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
        }
        //list used to save full path of files in opening history
        List<string> list=new List<string>();
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        /// <summary>
        /// click the button to set the panel of opened history to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        /// <summary>
        /// set the panel of opened history to open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        /// <summary>
        /// set the panel of opened history to open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please choose path";
            ofd.InitialDirectory = @"C:\Users\qtt1563\Desktop";
            ofd.Multiselect = true;
            ofd.Filter = "textfile|*.txt|allfiles|*.*";
            ofd.ShowDialog();
            string path = ofd.FileName;
            list.Add(path);
            string fileName = Path.GetFileName(path);
            listBox1.Items.Add(fileName);
            if (path == "")
            { return; }
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }
        /// <summary>
        /// Open a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"C:\Users\qtt1563\Desktop";
            sfd.Title = "please choose save path";
            sfd.Filter = "TextFiles|*.txt|all files|*.*";
            sfd.ShowDialog();
            string path = sfd.FileName;
            if (path == "")
            { return; }
            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("Save successfully");
        }
        /// <summary>
        /// by clicking the menue button to set feature of wordwrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Text == "Word Wrap")
            {
                textBox1.WordWrap = true;
                wordWrapToolStripMenuItem.Text = "Cancel Word Wrap";
            }
            else if (wordWrapToolStripMenuItem.Text == "Cancel Word Wrap")
            {
                textBox1.WordWrap = false;
                wordWrapToolStripMenuItem.Text = "Word Wrap";
            }

        }
        /// <summary>
        /// set font family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }
        /// <summary>
        /// set color family
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }
        /// <summary>
        /// Open file by clicking the content in the panel of opened history files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string path=list[listBox1.SelectedIndex];
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //each time fsRead reads 5 mb
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }

   

        
    }
}
