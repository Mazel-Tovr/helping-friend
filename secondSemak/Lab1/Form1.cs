using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        string connectString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Egor\Desktop\helping-friend-main\secondSemak\Lab1\Properties\clean.mdb";
        
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            //При ините формы делаем запрос бд на получение Клининговой компании
            initGrid();
        }

        private void initGrid()
        {
            string query = "SELECT Заказано.Код_заказа, Услуги.Название, Заказы.Дата_заказа, Клиенты.Название_клиента, Заказано.Бригада, Заказано.Объем AS ПлощадьУборки, Услуги.Стоимость AS СтоимостьЕдиницы, Скидки.Процент_скидки FROM(Скидки INNER JOIN Услуги ON Скидки.код = Услуги.Код) INNER JOIN((Клиенты INNER JOIN Заказы ON Клиенты.[Код клиента] = Заказы.Клиент) INNER JOIN Заказано ON Заказы.Код_заказа = Заказано.Код_заказа) ON Услуги.Код = Заказано.Код_услуги; ";//SQL Запрос 
            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "SELECT k FROM Клиенты WHERE (SELECT Z.Код_клиента FROM Заказы WHERE (SELECT ))";
            string query = "SELECT * FROM Клиенты WHERE Клиенты.[Код клиента] IN (SELECT Заказы.Клиент FROM (Заказано LEFT JOIN Заказы ON Заказано.Код_заказа = Заказы.Код_заказа) WHERE Заказано.Код_услуги = 2)"; 
           
            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            initGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "SELECT Заказы.[Код_заказа], Заказы.[Дата_заказа], Заказы.[Клиент] FROM Заказы WHERE(((Заказы.[Клиент]) = 10)); ";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            //???
            string query = "SELECT Заказы.[Код_заказа], Заказы.[Дата_заказа], Заказы.[Клиент] FROM Заказы WHERE((Заказы.[Дата_заказа] BETWEEN #01-02-2012# AND #29-02-2012#)); ";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT Заказано.Код_заказа, Заказано.Код_услуги, Заказано.Объем, Заказано.Бригада FROM Заказано LEFT JOIN Бригады ON Заказано.[Бригада] = Бригады.[Код] WHERE(((Бригады.Код) = 4) AND Заказано.Код_услуги = 3); ";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(Заказано.Объем) AS 'Суммарная площадь уборки' FROM Заказано WHERE Заказано.Бригада = 2";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(Заказано.Код_услуги) AS 'Количество заказов ежедневная уборка' FROM Заказано WHERE Заказано.Код_услуги = 1";

            OleDbCommand command = new OleDbCommand(query, myConnection);
            //Вывод данных в DataGridView
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            adapter.Update(dataSet);
        }
    }
}
