using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianRen_20260815_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Order> orders = new List<Order>();
        private void AddOrder_Click(object sender, EventArgs e)
        {
            if (drinks.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇飲料");
                return;
            }
            if (!middle.Checked && !large.Checked)
            {
                MessageBox.Show("請選擇杯型");
                return;
            }

            
            if(int.Parse(numOfDrinks.Text)<=0)
            {
                MessageBox.Show("飲料不得小於1杯");
                return;
            }

            orders.Add(new Order
            {
                drinkType = drinks.Text,
                isMiddle = middle.Checked,
                addToppings = new List<string> {
                    bobble.Checked?"珍珠":null,
                    cream.Checked?"奶油球":null
                }.Where(t=>t!=null).ToList(),
                count = int.Parse(numOfDrinks.Text),
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drinks.Items.AddRange(new object[]
            {
                "綠茶",
                "紅茶",
                "奶茶"
            });
        }
        
        class Order
        {
            public string drinkType { get; set; }
            public bool isMiddle { get; set; }
            string type => isMiddle ? "中杯" : "大杯";
        public List<string> addToppings {  get; set; }
            public int count { get; set; }
            //private int price =

            public override string ToString()
            {
                return $"{drinkType}/{type}/{string.Join("、", addToppings)} x {count} = ";
            }
        }
    }
}
