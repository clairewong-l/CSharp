using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine("输入两个数字");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("输入一个运算符 + - * /");
            char ch =char.Parse( Console.ReadLine());
            switch (ch)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("{0}+{1}={2}",num1,num2,result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("{0}-{1}={2}", num1, num2, result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("{0}*{1}={2}", num1, num2, result);
                    break;
                case '/':
                    if (num2 == 0) { Console.WriteLine("除数为0，请重新输入"); break; }
                    result = num1 / num2;
                    Console.WriteLine("{0}/{1}={2}", num1, num2, result);
                    break;
                default:
                    Console.WriteLine("没有这个运算符");
                    break;
            }

        }
    }
}
