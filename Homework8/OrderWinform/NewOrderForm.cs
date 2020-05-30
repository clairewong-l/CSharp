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
    public partial class NewOrderForm : Form
    {
        public Order currentOrder { get; set; }
        public NewOrderForm()
        {
            InitializeComponent();
            
        }
        public NewOrderForm(Order order, bool editMode = false) :this()
        {
            currentOrder = order;
            this.orderBindingSource.DataSource = currentOrder;
            if (!editMode)
            {
                currentOrder = orderBindingSource.Current as Order;
            }
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            currentOrder.OrderId = uint.Parse(orderIDText.Text);
            currentOrder.Customer = new Customer(rd.Next().ToString(), customerText.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            NewItemForm form = new NewItemForm(new OrderItem());
            if (form.ShowDialog() == DialogResult.OK)
            {
                currentOrder.AddItem(form.item);
            }
            this.itemBindingSource.ResetBindings(false);

        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = itemBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个商品删除");
                return;
            }
            currentOrder.RemoveItem(orderItem);
            itemBindingSource.ResetBindings(false);
        }

        private void EditItem()
        {
            OrderItem orderItem = itemBindingSource.Current as OrderItem;
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个商品进行修改");
                return;
            }
            NewItemForm form = new NewItemForm(orderItem);
            if (form.ShowDialog() == DialogResult.OK)
            {
                itemBindingSource.ResetBindings(false);
            }
        }

        private void editItemButton_Click(object sender, EventArgs e)
        {
            EditItem();
        }
    }
}
