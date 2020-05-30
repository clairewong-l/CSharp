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
    public partial class NewItemForm : Form
    {
        public OrderItem item { get; set; }

        public NewItemForm()
        {
            InitializeComponent();
        }
        public NewItemForm(OrderItem orderItem, bool editMode = false) :this()
        {
            item = orderItem;
            this.itemBindingSource.DataSource = orderItem;
            if (!editMode)
            {
                item = itemBindingSource.Current as OrderItem;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Goods goods = new Goods(rd.Next().ToString(), itemTextBox.Text, double.Parse(upBox.Text));
            item.GoodsItem.Name = itemTextBox.Text;
            item.GoodsItem.Price = double.Parse(upBox.Text);
            item.Quantity = uint.Parse(quantityBox.Text);
            item = new OrderItem(uint.Parse(rd.Next().ToString()), goods, uint.Parse(quantityBox.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
