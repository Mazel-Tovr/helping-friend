using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
     enum Types { 
            Люкс, 
            Полулюкс,
            Стандарт,
            Эконом,
     }
    public partial class Form1 : Form
    {
        private List<Hotel> hotels = new List<Hotel>();
        struct Hotel {
            public Types hotel;
            public int countOFliving;
            public bool isTv;
            public bool isFriedg;
            public int totalSumm;

            public Hotel(Types hotel, int countOFliving, bool isTv, bool isFriedg, int totalSumm)
            {
                this.hotel = hotel;
                this.countOFliving = countOFliving;
                this.isTv = isTv;
                this.isFriedg = isFriedg;
                this.totalSumm = totalSumm;
            }

            public override string ToString()
            {
                return "Номер " + hotel.ToString() + "; Количество людей " + countOFliving + "; Телевизор " + (isTv ? "Да": "Нет") + "; Холодильник " + (isFriedg ? "Да" : "Нет") + "; Сумма "+ totalSumm;
            }
        }

        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.Add("Да");
            comboBox2.Items.Add("Нет");
            comboBox2.SelectedItem = "Нет";           
            comboBox3.Items.Add("Да");
            comboBox3.Items.Add("Нет");
            comboBox3.SelectedItem = "Нет";
            sum.Text = 0.ToString();
            comboBox1.Items.Add(Types.Люкс.ToString());
            comboBox1.Items.Add(Types.Полулюкс.ToString());
            comboBox1.Items.Add(Types.Стандарт.ToString());
            comboBox1.Items.Add(Types.Эконом.ToString());
            comboBox1.SelectedItem = Types.Стандарт.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Люкс":
                    spaces.Text = 50.ToString();
                    sum.Text = 5000.ToString();
                    break;
                case "Полулюкс":
                    spaces.Text = 100.ToString();
                    sum.Text = 4000.ToString();
                    break;
                case "Стандарт":
                    spaces.Text = 240.ToString();
                    sum.Text = 3000.ToString();
                    break;
                case "Эконом":
                    spaces.Text = 140.ToString();
                    sum.Text = 2000.ToString();
                    break;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Types types = Types.Стандарт; 
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Люкс":
                    types = Types.Люкс;
                    break;
                case "Полулюкс":
                    types = Types.Полулюкс;
                    break;
                case "Стандарт":
                    types = Types.Стандарт;
                    break;
                case "Эконом":
                    types = Types.Эконом;
                    break;
            }

            Hotel hotel = new Hotel(types, int.Parse(textBox3.Text), tv(), friedg(), int.Parse(sum.Text));

            string hotelsFromList = "Room from list \n";
            hotels.ForEach(z => hotelsFromList = hotelsFromList + z.ToString() + "\n");
            MessageBox.Show("Current room :" + hotel.ToString() + "\n" + hotelsFromList);
        }

        private void addToArrayButton_Click(object sender, EventArgs e)
        {
            Types types = Types.Стандарт;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Люкс":
                    types = Types.Люкс;
                    break;
                case "Полулюкс":
                    types = Types.Полулюкс;
                    break;
                case "Стандарт":
                    types = Types.Стандарт;
                    break;
                case "Эконом":
                    types = Types.Эконом;
                    break;
            }

            Hotel hotel = new Hotel(types, int.Parse(textBox3.Text), tv(), friedg(), int.Parse(sum.Text));
            hotels.Add(hotel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int profit = hotels.Sum(z => z.totalSumm) + int.Parse(sum.Text);
            MessageBox.Show("Приболь сегодня " + profit);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Да":
                    sum.Text = (int.Parse(sum.Text) +  500).ToString();
                    break;
                case "Нет":
                    if (int.Parse(sum.Text) > 0)
                    {
                        sum.Text = (int.Parse(sum.Text) - 500).ToString();
                    }
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Да":
                    sum.Text = (int.Parse(sum.Text) + 350).ToString();
                    break;
                case "Нет":
                    if (int.Parse(sum.Text) > 0)
                    {
                        sum.Text = (int.Parse(sum.Text) - 350).ToString();
                    }
                    break;
            }
        }

        private bool friedg()
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "Да":
                    return true;
                case "Нет":
                    return false;
            }
            return false;
        }

        private bool tv()
        {
            switch (comboBox3.SelectedItem.ToString())
            {
                case "Да":
                    return true;
                case "Нет":
                    return false;
            }
            return false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            sum.Text = (int.Parse(sum.Text) * int.Parse(textBox3.Text)).ToString();
        }
    }
}
