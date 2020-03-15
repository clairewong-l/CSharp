using System;

namespace Array_Calculate
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] num = new int[10];
            Console.WriteLine("输入"+num.Length+"个整数：");
            int count=0, max, min,sum;
            for  (; count < num.Length;count++)
                num[count] = int.Parse(Console.ReadLine());
            for(count=1,max=min=sum=num[0];count<num.Length;count++)
            {
                sum += num[count];
                if (num[count] > max) max = num[count];
                else if (num[count] < min) min = num[count];
            }
            Console.WriteLine("最大数为：" + max);
            Console.WriteLine("最小数为：" + min);
            Console.WriteLine("总和为：" + sum);
            Console.WriteLine("平均数为：" + (sum / num.Length));
        }
    }
}
