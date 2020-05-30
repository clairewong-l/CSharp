using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderApp;

namespace OrderWinform
{
    public partial class Form1 : Form
    {
        OrderService orderService;
        BindingSource fieldsBS = new BindingSource();
        public String SearchValue { get; set; }

        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            Customer customer1 = new Customer("1012", "Hana");
            Customer customer2 = new Customer("1013", "Tobby");
            Goods goods1 = new Goods("1", "strawberry", 20);
            Goods goods2 = new Goods("2", "milktea", 15);
            Goods goods3 = new Goods("3", "lune", 1000);
            Order order1 = new Order(1220, customer1, new List<OrderItem>());
            order1.AddItem(new OrderItem(2, goods1,100));
            order1.AddItem(new OrderItem(3, goods2,30));
            Order order2 = new Order(4011, customer2, new List<OrderItem>());
            order2.AddItem(new OrderItem(1, goods3, 1));
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderBindingSource.DataSource = orderService.Orders;
            combo.SelectedIndex = 0;

            searchValue.DataBindings.Add("Text", this, "SearchValue");
        }

        private void QueryAll()
        {
            orderBindingSource.DataSource = orderService.Orders;
            orderBindingSource.ResetBindings(false);
        }

        private void button_newOrder_Click(object sender, EventArgs e)
        {
            NewOrderForm newOrderForm = new NewOrderForm(new Order());
            if (newOrderForm.ShowDialog() == DialogResult.OK)
            {
                orderService.AddOrder(newOrderForm.currentOrder);
                QueryAll();
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            switch (combo.SelectedIndex)
            {
                case 0:
                    orderBindingSource.DataSource = orderService.Orders;
                    break;
                case 1:
                    int.TryParse(SearchValue, out int id);
                    Order order = orderService.GetOrder((uint)id);
                    List<Order> result = new List<Order>();
                    if (order != null) result.Add(order);
                    orderBindingSource.DataSource = result;
                    break;
                case 2:
                    orderBindingSource.DataSource = orderService.QueryOrdersByCustomerName(SearchValue);
                    break;
                case 3:
                    orderBindingSource.DataSource = orderService.QueryOrdersByGoodsName(SearchValue);
                    break;
            }
            orderBindingSource.ResetBindings(true);
        }

        private void button_deleteOrder_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            orderService.RemoveOrder(order.OrderId);
            QueryAll();
        }

        private void button_exportOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void button_importOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                QueryAll();
            }
        }
        private void EditOrder()
        {
            Order order = orderBindingSource.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            NewOrderForm form2 = new NewOrderForm(order);
            if (form2.ShowDialog() == DialogResult.OK)
            {
                orderService.UpdateOrder(form2.currentOrder);
                QueryAll();
            }
        }

        private void button_modifyOrder_Click(object sender, EventArgs e)
        {
            EditOrder();
        }
    }
}
