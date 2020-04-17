using System;
using System.Collections.Generic;

namespace OderManage
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("Ariel");
            Order order2 = new Order("Anna");
            OrderItem item1 = new OrderItem("cola", 12, 2.8);
            OrderItem item2 = new OrderItem("cookies", 30, 5.5);
            orderService.AddOrder(order1);
            orderService.AddOrderItem(order1, item1);
            orderService.AddOrderItem(order1, item2);
            orderService.AddOrder(order2);
            orderService.AddOrderItem(order2,item2);
            orderService.SearchByClient("Ariel").ForEach(o => Console.WriteLine(o.ToString()));

            while (true)
            {
                Console.WriteLine("请输入功能代码：1.添加订单 2.删除订单 3.修改订单 4. 查询订单");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine("请输入订单客户");
                        Order order = new Order(Console.ReadLine());
                        orderService.AddOrder(order);
                        break;
                    case 2:
                        Console.WriteLine("请输入待删除订单号");
                        orderService.DeleteOrder(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("请输入待修改订单号");
                        orderService.ReviseOrder(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("按照哪一项进行查询？");
                        Console.WriteLine("1.订单号 2.商品名 3.客户");
                        List<Order> sOrders = null;
                        int j = int.Parse(Console.ReadLine());
                        switch (j)
                        {
                            case 1:
                                Console.WriteLine("请输入订单号");
                                sOrders = orderService.SearchByID(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("请输入商品名");
                                sOrders = orderService.SearchByItem(Console.ReadLine());
                                sOrders.ForEach(o => Console.WriteLine(o.ToString()));
                                break;
                            case 3:
                                Console.WriteLine("请输入客户名");
                                sOrders = orderService.SearchByClient(Console.ReadLine());
                                sOrders.ForEach(o => Console.WriteLine(o.ToString()));
                                break;
                            default: Console.WriteLine("输入错误"); break;
                        }
                        foreach (Order o in sOrders)
                           Console.WriteLine( o.ToString());
                        break;
                }
                Console.WriteLine("输入任意键继续执行，输入Q结束");
                string s = Console.ReadLine();
                if (s == "Q") break;
                else continue;
            }
        }
    }
}
