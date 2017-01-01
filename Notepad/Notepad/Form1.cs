using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("all right reserved", "help");
        }

        private void mainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            mainRichTextBox.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainRichTextBox.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "open";
            of.Filter = "text document(*.txt)|*.txt|AllowDrop files(*.*)";
            if (of.ShowDialog() == DialogResult.OK)
                mainRichTextBox.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            this.Text = of.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "save";
            sd.Filter = "text document(*.txt)|*.txt|all files(*.*)";
            if (sd.ShowDialog() == DialogResult.OK)
                mainRichTextBox.SaveFile(sd.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sd.FileName;

        }
    }
}
