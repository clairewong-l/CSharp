using System;
using System.Collections.Generic;
using System.Linq;

namespace OderManage
{
    public class Order
    {
        private string _orderID;
        public string OderID
        {
            get { return _orderID; }
            set { _orderID = value; }
        }
        private double _sumMoney;
        public double SumMoney
        {
            get { return 0.0; }
            set { _sumMoney = value; }
        }
        private string _orderTime;
        public string OderTime
        {
            get { return _orderTime; }
            set { _orderTime = value; }
        }
        private string _client;
        public string Client
        {
            get { return _client; }
            set { _client = value; }
        }

        private List<OrderItem> items = new List<OrderItem>();//使用List存放订单明细项

        //构造方法
        public Order(string client)
        {
            this.Client = client;
            Random rd = new Random();
            this.OderTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:s");
            this.OderID = DateTime.Now.ToString("yyMMddHHmmss");
        }
        //增加订单明细项
        public void AddItem(OrderItem item)
        {
            OrderItem i = new OrderItem(item.itemName, item.itemQty, item.itemUP);
            foreach (OrderItem element in items)  
            {
                if (element.Equals(item)) Console.WriteLine("该商品已添加！");
                return;
            }
            items.Add(i);
            SumMoney += i.itemPrice;
            Console.WriteLine(item.ToString());
        }
        //删除订单明细项
        public void DeleteItem(OrderItem item)
        {
            foreach (OrderItem element in items)
            {
                if (element.Equals(item))
                {
                    items.Remove(element);
                    SumMoney -= element.itemPrice;
                    return;
                }
            }
            Console.WriteLine("删除失败！没有{0}商品",item.itemName);
        }
        //通过商品名搜索订单明细
        public OrderItem SearchByItem(string item)
        {
            var query = from i in items
                        where i.itemName == item
                        select i;
            if (query == null) return null;
            else return query as OrderItem;
        }
        //重写ToString
        public override string ToString()
        {
            string s = "";
            foreach (OrderItem item in items)
                s += "\n"+item.ToString() ;
            return "订单号："+_orderID + "\n订单时间："+ _orderTime
                + "\n客户："+ _client + "\n总金额："+ _sumMoney+s;
        }
        //重写Equals方法
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            if (order != null && order.OderID == this.OderID) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return this.OderID.GetHashCode();
        }
    }
}
