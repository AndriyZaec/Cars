using System;
using System.IO;
using System.Windows.Forms;

namespace Cars
{
    public partial class Adding : Form
    {
        public Adding()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(FileWorking.path,true);

            string temp = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text;

            writer.WriteLine(temp);

            writer.Close();

            MainForm mainForm = new MainForm();
            mainForm.RefreshingForm();
            Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Images| *.png; *.jpg; *.jpeg";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox5.Text = openFileDialog.FileName;
            }
        }
    }
}
