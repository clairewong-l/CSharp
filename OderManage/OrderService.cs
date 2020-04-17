using System;
using System.Collections.Generic;
using System.Linq;

namespace OderManage
{
    public class OrderService
    {
        private List<Order> orders;
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
            var query = from o in orders
                        where o.SearchByItem(item) != null
                        orderby o.SumMoney
                        select o;
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
            var query = from o in orders
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
            if (SearchByID(order.OderID) != null)
                Console.WriteLine("已存在该订单！\n添加订单失败");
            else
            {
                orders.Add(order);
                /*Console.WriteLine("请依次添加订单明细，" +
                    "分别输入商品名称、商品数量、商品单价。");
                string name;
                int qty;
                float up;
                while (true)
                {
                    name = Console.ReadLine();
                    qty = int.Parse(Console.ReadLine());
                    up = float.Parse(Console.ReadLine());
                    order.AddItem(new OrderItem(name, qty, up));
                    Console.WriteLine("输入任意键继续添加，输入Q结束");
                    string s = Console.ReadLine();
                    if (s == "Q") break;
                    else continue;
                }*/
                Console.WriteLine($"添加订单{order.OderID}成功！");
            }
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
            Order order = SearchByID(id).First();
            if(order!=null)
            {
                orders.Remove(order);
                Console.WriteLine("已删除{0}订单", id);
            }
            else
                Console.WriteLine("删除异常!");
        }
        //修改订单
        public void ReviseOrder(string id)
        {
            Order order = SearchByID(id).First();
            if (order == null) return;
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
    }
    class InputException : ApplicationException
    {
        public InputException(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
