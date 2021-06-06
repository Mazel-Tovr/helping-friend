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

namespace ExhibitionCenter
{
    public partial class Form1 : Form
    {
        enum Type
        {
            Живопись,
            Графика,
            Скульптура,
            Гравюра
        }
        struct Exhibit
        {
            public string name;
            public string createrName;
            public Type type;
            public string city;
            public bool isNew;
            public DateTime date;

            public Exhibit(string name, string createrName, Type type, string city, bool isNew, DateTime date)
            {
                this.name = name;
                this.createrName = createrName;
                this.type = type;
                this.city = city;
                this.isNew = isNew;
                this.date = date;
            }
            public override string ToString()
            {
                return name + ";"+createrName + ";" + type.ToString() + ";" + city + ";" + (isNew ? "Да": "Нет") + ";" + date.ToShortDateString();
            }
        }
        private List<Exhibit> exhibits = new List<Exhibit>();
        public Form1()
        {
            InitializeComponent();
            readFromFile();
            fillTb(exhibits);
            comboBox1.Items.Add(Type.Живопись);
            comboBox1.Items.Add(Type.Гравюра);
            comboBox1.Items.Add(Type.Скульптура);
            comboBox1.Items.Add(Type.Гравюра);
            comboBox1.SelectedItem = Type.Гравюра;
        }

        private void readFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\GitHub\helping-friend\secondSemak\FourthTask\Exhibition.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(';');
                string name = data[0];
                string createrName = data[1];
                Enum.TryParse(data[2], out Type type);
                string city = data[3];
                bool isNew =  data[4] == "Да";
                DateTime date = DateTime.Parse(data[5]);
                exhibits.Add(new Exhibit(name,createrName,type,city,isNew,date));
            }
        }


        private void fillTb(List<Exhibit> exhibits, bool writeToFile = false)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Экспонат");
            dt.Columns.Add("Имя художника");
            dt.Columns.Add("Профиль");
            dt.Columns.Add("Город проживания");
            dt.Columns.Add("Выставлялся ли автор ранее в данном выставочном центре");
            dt.Columns.Add("Дата");
            for (int i = 0; i < exhibits.Count; i++)
            {
                Exhibit h = exhibits[i];
                object[] f = { h.name, h.createrName, h.type.ToString(), h.city, h.isNew ? "Да" : "Нет" , h.date.ToShortDateString()};
                dt.Rows.Add(f);

            }
            dataGridView1.DataSource = dt;
            if (writeToFile)
            {
                StreamWriter writetext = new StreamWriter("search.txt");
                exhibits.ForEach(z => writetext.WriteLine(z.ToString()));
                writetext.WriteLine(DateTime.Now);
                writetext.Flush();
                writetext.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out Type type);
            fillTb(exhibits.Where(z => z.type == type).ToList());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fillTb(exhibits.Where(z => z.city.Contains(textBox1.Text)).ToList());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enum.TryParse(comboBox1.SelectedItem.ToString(), out Type type);
            fillTb(exhibits.Where(z => z.city.Contains(textBox1.Text) && z.type == type).ToList(),true);
        }
    }
}
