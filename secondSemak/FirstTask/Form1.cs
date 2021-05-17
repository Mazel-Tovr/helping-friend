using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private List<PS> computes = new List<PS>() {
            new PS("Mac",2000 , "Mac OS"), new PS("MSI",1000,"Windows"), new PS("hyperpc", 500,"Linux"),new PS("Gameing ps",500,"FreeBsd")
        };
        public Form1()
        {
            InitializeComponent();
            computes.ForEach(e=>this.ps.Items.Add(e));
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
            double input = double.Parse(sum.Text);
            double totalsum = double.Parse(total.Text);
            if(totalsum > input)
            {
                MessageBox.Show("Недостаточно денег");
            } else
            {
                MessageBox.Show("Покупка совершена. Сдача:" + (input - totalsum));
                change.Text = (input - totalsum).ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<PS> computes1 = new List<PS>();
            var enumerator = ps.SelectedItems.GetEnumerator();
            while (enumerator.MoveNext())
            {
                computes1.Add((PS)enumerator.Current);
            }
            double sum = 0;
            po.Items.Clear();
            computes1.ForEach(z => { 
                sum += z.price;
                po.Items.Add(z.po);
            });
            total.Text =  sum.ToString();
        }
    }

    struct PS
    {
        public PS(String name, double price, string po)
        {
            this.name = name;
            this.price = price;
            this.po = po;
        }
        public string name;
        public double price;
        public string po;

        public override string ToString()
        {
            return name + " " + price;
        }
    }

   
}
