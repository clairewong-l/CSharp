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
        public double SumMoney
        {
            get => items.Sum(item => item.itemPrice);
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

        private List<OrderItem> items;//使用List存放订单明细项
        public List<OrderItem> Items
        {
            get { return items; }
        }

        //构造方法
        public Order(string client, List<OrderItem> items)
        {
            this.Client = client;
            Random rd = new Random();
            this.OderTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:s");
            this.OderID = DateTime.Now.ToString("yyMMddHHmmss")+rd.Next(1,9);
            this.items = items ?? new List<OrderItem>();
        }
        //增加订单明细项
        public void AddItem(OrderItem item)
        {
            if (items.Contains(item))
                throw new ApplicationException($"Orderitem {item.itemName} exists!");
            items.Add(item);
            Console.WriteLine(item.ToString());
        }
        //删除订单明细项
        public void DeleteItem(OrderItem item)
        {
            items.Remove(item);
        }
        //通过商品名搜索订单明细
        public OrderItem SearchByItem(string itemName)
        {
            var query =items.Where(item=>item.itemName==itemName);
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
                + "\n客户："+ _client + "\n总金额："+ SumMoney+s;
        }
        //重写Equals方法
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.OderID == this.OderID;
        }
        public override int GetHashCode()
        {
            return this.OderID.GetHashCode();
        }
    }
}
