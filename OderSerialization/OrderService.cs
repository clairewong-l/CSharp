using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace OderManage
{
    public class OrderService
    {
        private List<Order> orders;
        public List<Order> Orders
        {
            get { return orders; }
        }
        public OrderService()
        {
            this.orders = new List<Order>();
        }
        //按照订单号搜索订单
        public List<Order> SearchByID(string id)
        {
            var query = from o in orders
                          where o.OderID == id
                          select o;
            if (query == null) {
                Console.WriteLine("没有订单{0}", id);
                return null;
            }
            return query.ToList<Order>();
        }
        //按照商品名称搜索订单
        public List<Order> SearchByItem(string item)
        {
            var query = orders
                .Where(order => order.Items.Exists(i => i.itemName == item))
                .OrderBy(order => order.SumMoney);
            if (query == null)
            {
                Console.WriteLine("没有含有{0}的订单", item);
                return null;
            }
            return query.ToList<Order>();
        }
        //按照客户名搜索订单
        public List<Order> SearchByClient(string client)
        {

            IOrderedEnumerable<Order> query = from o in orders
                        where o.Client == client
                        orderby o.SumMoney
                        select o;
            if (query == null)
            {
                Console.WriteLine("没有客户{0}的订单", client);
                return null;
            }
            return query.ToList<Order>();
        }
        //添加新订单
        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ApplicationException($"订单{order.OderID}已存在");
            orders.Add(order);
        }
        //为订单添加订单明细
        public void AddOrderItem(Order order, OrderItem item)
        {
            if(order!=null&&item!=null)
                order.AddItem(item);
        }
        //删除订单
        public void DeleteOrder(string id)
        {
            Order order = SearchByID(id).FirstOrDefault();
            if (order == null)
            {
                Console.WriteLine("没有这个订单，删除异常!");
            }
            else
            {
                orders.Remove(order);
                Console.WriteLine("已删除{0}订单", id);
            }
        }
        //修改订单
        public void ReviseOrder(string id)
        {
            Order order = SearchByID(id).FirstOrDefault();
            if (order == null)
            {
                Console.WriteLine("没有这个订单，修改异常！");
                return;
            }
            order.ToString();
            Console.WriteLine("请输入需要修改的项目代号：1.客户名 2.订单明细");
            int i ;
            while ((i = int.Parse(Console.ReadLine())) != -10000)
            {
                try
                {
                    if (i != 1 && i != 2)
                        throw new InputException("输入错误");
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    continue;
                }
                break;
            }
            switch (i)
            {
                case 1:
                    Console.WriteLine("请输入新客户名");
                    order.Client = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("请输入需修改的商品名称");
                    string s = Console.ReadLine();
                    OrderItem item = order.SearchByItem(s);
                    while(item==null)
                    {
                        Console.WriteLine("该订单中没有该商品，请重新输入");
                        item = order.SearchByItem(Console.ReadLine());
                    }
                    Console.WriteLine("请输入需要修改的项目代号：" +
                        "1.商品名 2.数量 3.单价 4.删除订单明细");
                    while ((i = int.Parse(Console.ReadLine())) != -10000)
                    {
                        try
                        {
                            if (i != 1 && i != 2 && i != 3 && i != 4)
                                throw new InputException("输入错误");
                        }
                        catch
                        {
                            Console.WriteLine("请重新输入");
                            continue;
                        }
                        break;
                    }
                    Console.WriteLine("请输入修改");
                    var revise = Console.ReadLine();
                    switch (i)
                    {
                        case 1:
                            item.itemName = revise;break;
                        case 2:
                            item.itemQty = int.Parse(revise);break;
                        case 3:
                            item.itemUP = float.Parse(revise);break;
                        case 4:
                            order.DeleteItem(item);break;
                        default:break;
                    }
                    break;
            }
            Console.WriteLine("修改成功！");
        }
        public string SortOrders()
        {
            orders.Sort((o1, o2) => o1.OderID.CompareTo(o2.OderID));
            string val = "";
            if (orders.Count() == 0) return val;
            foreach(Order o in orders)
            {
                val += o.OderID + "\n";
            }
            return val.Substring(0, val.Length - 1);
        }
        public void Export(String Filename)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream(Filename, FileMode.Create))
            {
                xs.Serialize(fs, Orders);
            }
        }
        public void Import(String Filename)
        {

            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(Filename, FileMode.Open))
            {
                List<Order> orders = (List<Order>)xs.Deserialize(fs);
                orders.ForEach(order =>
                {
                    if (!Orders.Contains(order))
                        Orders.Add(order);
                }
                ) ;

            }
        }
    }
    class InputException : ApplicationException
    {
        public InputException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
