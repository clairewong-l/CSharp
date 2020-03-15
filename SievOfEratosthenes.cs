using System;

namespace SievOfEratosthenes
{
    class MainClass
    {
        const int maxNum = 101;
        const int squareRoot = 11;
        public static void Main(string[] args)
        {
            int[] num = new int[maxNum];
            int i,j;
            //]将非素数置1
            for(i=2;i<squareRoot;i++)
            {
                if (num[i] == 1) continue;
                for(j=i+1;j<maxNum;j++)
                {
                    if (j % i == 0) num[j] = 1;
                }
            }
            //输出所有素数
            Console.WriteLine("2～100以内的素数有：");
            for(i=2;i<maxNum;i++)
            {
                if (num[i] == 0) Console.WriteLine(i);  
            }
        }
    }
}
