using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cars
{
    public partial class Searching : Form
    {
        private List<Car> _cars = new List<Car>();
        Validation validete = new Validation();

        public Searching(List<Car> list)
        {
            InitializeComponent();
            _cars = list;
        }

        private void MaxSearch_Load(object sender, EventArgs e)
        {
            foreach(var el in _cars)
            {
                string temp = el.Model;
                string[] split = temp.Split(new char[] { ' ' });

                if (!CarsNames.Items.Contains(split[0]))
                {
                    CarsNames.Items.Add(split[0]);
                }

                CarsNames.SelectedIndex = 0;  
            }

            foreach (var el in _cars)
            {
                if (!CarColor.Items.Contains(el.Color))
                {
                    CarColor.Items.Add(el.Color);
                }
            }

            CarColor.SelectedIndex = 0;
        }

        private void CarsNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Car> searchedCars = new List<Car>();

            foreach (var el in _cars)
            {
                string temp = el.Model;
                string[] split = temp.Split(new char[] { ' ' });

                if (split[0] == CarsNames.SelectedItem.ToString())
                {
                    searchedCars.Add(el);
                }
            }

            int maxPower = 0;
            decimal maxPrice = 0;

            foreach (var el in searchedCars)
            {
                if (el.Price > maxPrice)
                {
                    maxPrice = el.Price;
                    MaxPriceOutput.Text = "Найдорожчий: " + el.Model + " " + maxPrice + "₴";
                }
                if (el.Power > maxPower)
                {
                    maxPower = el.Power;
                    MaxPowerOutput.Text = "Найпотужніший: " + el.Model + " " + maxPower + "к.с.";
                }
            }

            searchedCars.Clear();
        }

        private void CarColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarsWithSameColor.Items.Clear();

            foreach (var el in _cars)
            {
                if (CarColor.SelectedItem.ToString() == el.Color)
                {
                    CarsWithSameColor.Items.Add(el.Model + "\t" + el.Color);
                }
            }

        }

        private void SearchCar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (From.Text != " " && To.Text != "")
            {
                foreach(var el in _cars)
                {
                    if (decimal.Parse(From.Text) <= el.Price && decimal.Parse(To.Text) >= el.Price )
                    {
                        listBox1.Items.Add(el.Model +"\t"+ el.Price);
                    }
                }  
            }
            else
            {
                MessageBox.Show("Ви не ввели ціну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void From_KeyPress(object sender, KeyPressEventArgs e)
        {
            validete.Validete(e);
        }

        private void To_KeyPress(object sender, KeyPressEventArgs e)
        {
            validete.Validete(e);
        }
    }
}
