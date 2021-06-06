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
            readFromFile();
            fillTb();
        }


        private void readFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\GitHub\helping-friend\secondSemak\ThirdTask\rooms.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(';');
                Enum.TryParse(data[0], out Types types);
                int count = int.Parse(data[1]);
                bool isTv = data[2] == "Да";
                bool isFriedg = data[3] == "Да";
                int totalSumm = int.Parse(data[4]); ;
                hotels.Add(new Hotel(types, count, isTv, isFriedg, totalSumm));
            }
        }

        private void fillTb()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Тип");
            dt.Columns.Add("число живущих");
            dt.Columns.Add("Тв");
            dt.Columns.Add("Холодильник");
            dt.Columns.Add("Сумма");
            for (int i = 0; i < hotels.Count; i++)
            {
                Hotel h = hotels[i];
                object[] f = { h.hotel.ToString(), h.countOFliving, h.isTv ? "Да" : "Нет", h.isFriedg ? "Да" : "Нет", h.totalSumm };
                dt.Rows.Add(f);

            }
            dataGridView1.DataSource = dt;
        }



        private void printButton_Click(object sender, EventArgs e)
        {
            hotels.Sort((x, y) => x.totalSumm > y.totalSumm ? 1 : -1);
            fillTb();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hotels.Sort((x, y) => x.countOFliving > y.countOFliving ? 1 : -1);
            fillTb();
        }
    }
}
