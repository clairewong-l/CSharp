using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace OderManage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                OrderService orderService = new OrderService();

                OrderItem cola = new OrderItem("cola", 12, 2.8);
                OrderItem biscuit = new OrderItem("cookies", 30, 5.5);
                OrderItem grape = new OrderItem("grapes", 20, 12.6);

                Order order1 = new Order("Ariel", new List<OrderItem> { cola, biscuit, grape });
                Order order2 = new Order("Anna", new List<OrderItem> { cola });

                orderService.AddOrder(order1);
                orderService.AddOrder(order2);

                Console.WriteLine("所有订单：");
                orderService.Orders.ForEach(o => Console.WriteLine(o.ToString()));
                Console.WriteLine("");

                Console.WriteLine("查询客户名为Ariel的订单：");
                orderService.SearchByClient("Ariel").ForEach(o => Console.WriteLine(o.ToString()));
                Console.WriteLine("");

                Console.WriteLine("查询订单中含有cola的订单:");
                orderService.SearchByItem("cola").ForEach(o => Console.WriteLine(o.ToString()));
                Console.WriteLine("");

                Console.WriteLine("查询订单号为2004182221301的订单:");
                orderService.SearchByID("20041822").ForEach(o => Console.WriteLine(o.ToString()));
                Console.WriteLine("");

                Console.WriteLine("根据订单号排序订单:");
                Console.WriteLine(orderService.SortOrders());
                Console.WriteLine("");

                Console.WriteLine("删除订单号为2004182221301的订单:");
                orderService.DeleteOrder("2004182221301");
                Console.WriteLine("");

                Console.WriteLine("修改订单2004182221301:");
                orderService.ReviseOrder("2004182221301");

                Console.WriteLine("从文件 orders.xml 导入订单：");
                OrderService os = new OrderService();
                os.Import("~/orders.xml");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
