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
        string connectString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\GitHub\helping-friend\secondSemak\Lab1\Properties\clean.mdb";
        
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string query = "SELECT k FROM Клиенты WHERE (SELECT Z.Код_клиента FROM Заказы WHERE (SELECT ))";
            string query = "SELECT [Клиенты Without Matching Заказы Without Matching Заказано].[Код клиента], [Клиенты Without Matching Заказы Without Matching Заказано].Название_клиента, [Клиенты Without Matching Заказы Without Matching Заказано].Дата_регистрации, [Клиенты Without Matching Заказы Without Matching Заказано].Категория FROM[Клиенты Without Matching Заказы Without Matching Заказано] LEFT JOIN Услуги ON[Клиенты Without Matching Заказы Without Matching Заказано].[Код_услуги] = Услуги.[Код] WHERE(((Услуги.Код) = 2)); "; 
           
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
            string query = "SELECT Заказы.[Код_заказа], Заказы.[Дата_заказа], Заказы.[Клиент] FROM Заказы WHERE((Заказы.[Дата_заказа] BETWEEN 01-02-2012 AND 30-02-2012)); ";

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
            string query = "SELECT Заказано.Код_заказа, Заказано.Код_услуги, Заказано.Объем, Заказано.Бригада FROM Заказано LEFT JOIN Бригады ON Заказано.[Бригада] = Бригады.[Код] WHERE(((Бригады.Код) = 4)); ";

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
