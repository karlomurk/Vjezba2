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


namespace Vjezba2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Otvaranje datoteke",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                RestoreDirectory = true,

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Text = openFileDialog1.FileName;

                string naziv_datoteke = openFileDialog1.FileName;
                string tekst_datoteke = File.ReadAllText(naziv_datoteke);
                richTextBox1.Text = tekst_datoteke;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                richTextBox3.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Spremanje izmjena otvorene datoteke";
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            string FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
                richTextBox1.SaveFile(FileName, RichTextBoxStreamType.PlainText);
            }
        }
       
    }
} 

