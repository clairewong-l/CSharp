using System;
namespace OderManage
{
    public class OrderItem
    {
        public string itemName { get; set; }
        public int itemQty { get; set; }
        public double itemUP { get; set; }//商品单价
        public double  itemPrice { get => itemQty * itemUP; }

        public OrderItem(string name, int q, double up)
        {
            this.itemName = name;
            this.itemQty = q;
            this.itemUP = up;
        }

        override public string ToString()
        {
            return itemName.PadRight(15) + itemQty.ToString().PadRight(5)
                + itemUP.ToString().PadRight(5) + itemPrice.ToString().PadRight(5);
        }
        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item != null && item.itemName == this.itemName;
        }
        public override int GetHashCode()
        {
            return this.itemName.GetHashCode();
        }

    }
}
