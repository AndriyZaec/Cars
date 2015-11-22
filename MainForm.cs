using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cars
{
    public partial class MainForm : Form
    {
        FileWorking fileWorking = new FileWorking();
        List<Car> _cars = new List<Car>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileWorking.Create();
            _cars = fileWorking.Read();
          
            foreach (Car el in _cars)
            {
                CarsTable.Rows.Add(el.Model, el.Color, el.Price, el.Power);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Adding adding = new Adding();
            adding.Show();
        }

        public void RefreshingForm()
        {
            CarsTable.Refresh();
        }

        private void CarsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO картинка по кліку
            //string path = CarsTable.Rows[e.RowIndex].Cells["picture"].Value;
            //pictureBox.ImageLocation = path;
        }
    }
}
