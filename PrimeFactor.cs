using System;

namespace PrimeFactor
{
    class Program
    {
        public static int ReadInt()
        {
            int num = 0;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] a = new int[1000];
            int i = 0;
            int num;

            //输入
            Console.WriteLine("输入需要分解素数因子的数字：");
            num = ReadInt();

            //求素数因子
            Console.WriteLine("{0}的素数因子有：", num);
            for(i=2; i<=num; i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine(i);
                    while (num % i == 0) num = num / i;
                }
                if (num == 1) break;
            }

            
        }
    }
}
