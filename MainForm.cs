using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cars
{
    public partial class MainForm : Form
    {
        FileWorking fileWorking = new FileWorking();
        List<Car> _cars = new List<Car>();

        Validation valid = new Validation();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileWorking.Create();

            Refreshing();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Model.Clear(); Model.ReadOnly = false;
            Color.Clear(); Color.ReadOnly = false;
            Price.Clear(); Price.ReadOnly = false;
            Power.Clear(); Power.ReadOnly = false;

            Create.Visible = false;
            SaveNew.Visible = true;
        }

        private void SaveNew_Click(object sender, EventArgs e)
        {
            if (Model.Text != "" && Color.Text != "" && Price.Text != "" && Power.Text != "")
            {
                string temp = Model.Text + "|" + Color.Text + "|" + Price.Text + "|" + Power.Text;

                fileWorking.Adding(temp);

                CarList.Items.Clear();

                _cars.Clear();

                Refreshing();

                Create.Visible = true;
                SaveNew.Visible = false;
            }
            else
            {
                MessageBox.Show("Дані не введено!\nПереконайтесь, що заповнили всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {

            int index = CarList.SelectedIndex;
            _cars.RemoveAt(index);

            fileWorking.Update(_cars);

            CarList.SelectedIndex = 0;
            CarList.Items.RemoveAt(index);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Edit.Visible = false;
            Save.Visible = true;

            Model.ReadOnly = false;
            Color.ReadOnly = false;
            Price.ReadOnly = false;
            Power.ReadOnly = false;

            int index = CarList.SelectedIndex;
            _cars.RemoveAt(index);


        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Model.Text != "" && Color.Text != "" && Price.Text != "" && Power.Text != "")
            {
                Save.Visible = false;
                Edit.Visible = true;

                _cars.Add(new Car() { Model = Model.Text, Color = Color.Text, Price = decimal.Parse(Price.Text), Power = int.Parse(Power.Text) });

                fileWorking.Update(_cars);

                CarList.Items.Clear();
                _cars.Clear();

                _cars = fileWorking.Read();

                foreach (Car el in _cars)
                {
                    CarList.Items.Add(el.Model);
                }
            }
            else
            {
                MessageBox.Show("Дані не введено! \n Переконайтесь, що заповнили всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string temp = CarList.SelectedItem.ToString();
                foreach (var el in _cars)
                {
                    if (el.Model == temp)
                    {
                        Model.Text = el.Model;
                        Color.Text = el.Color;
                        Price.Text = el.Price.ToString();
                        Power.Text = el.Power.ToString();
                    }
                }
            }
            catch
            {

            }
        }

        public void Refreshing()
        {
            _cars = fileWorking.Read();

            foreach (Car el in _cars)
            {
                CarList.Items.Add(el.Model);
            }

            CarList.SelectedIndex = 0;
        }

        private void PriceSort_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            SortedData.Visible = true;

            SortedData.Items.Clear();

            decimal[] Prices = new decimal[_cars.Capacity];
            int i = 0;

            foreach(var el in _cars)
            {
                Prices[i] = el.Price;
                i++;
            }

            Prices = shellSort(Prices);

            for (i = 0; i < _cars.Capacity; i++)
            {
                foreach(var el in _cars)
                {
                    if (el.Price == Prices[i])
                    {
                        SortedData.Items.Add(el.Model + "\t" + el.Price);
                    }
                }
            }

            ClientSize = new System.Drawing.Size(950, 463);
        }

        private decimal[] shellSort(decimal[] vector)
        {
            int step = vector.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < vector.Length; i++)
                {
                    decimal value = vector[i];
                    for (j = i - step; (j >= 0) && (vector[j] > value); j -= step)
                        vector[j + step] = vector[j];
                    vector[j + step] = value;
                }
                step /= 2;
            }
            return vector;
        }

        private void CloseSort_Click(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(667, 463);
            label6.Visible = false;
            SortedData.Visible = false;
        }

        private void MaxSearch_Click(object sender, EventArgs e)
        {
            Searching maxSearchForm = new Searching(_cars);
            maxSearchForm.Show();
        }

        private void OptimalCarsInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void Closing_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.Validete(e);
        }

        private void Power_KeyPress(object sender, KeyPressEventArgs e)
        {
            valid.Validete(e);
        }

        private void Help_Click(object sender, EventArgs e)
        {
            string text = "Даний програмний продукт розроблений для швидкого доступу до інформації про авто\n"
                + "\nІнструкція з використання:\n\n 1)Перегляд автомобілів здійснюється кліком на них правою кнопкою миші "
                + "у загальномусписку, детальніша інформація виводиться у полях правіше від списку.\n\n"
                + "2)Кнопки додавання, видалення та редагування знаходяться під списком, та розміщені у відповідному порядку.\n\n"
                + "3)Вертикальне меню справа від списку, дає змогу посортувати, відкрити вікно пошуку та вивести оптимальні авто"
                + "кожного найменування.\n\n"
                + "Програму розробив Заєць Андрій ПІст-11";

            MessageBox.Show(text,"Довідка", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
