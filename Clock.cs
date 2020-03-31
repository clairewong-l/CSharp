using System;
using System.Threading;

namespace MyClock
{
    public class Clock
    {
        //声明事件
        public event TimerCallback TimerCB;
        public void Do(string alarmTime)
        {
            Timer t = new Timer(TimerCB, alarmTime, 0, 1000);   //一秒钟调用一次,实现计时功能
            Console.WriteLine("Press Enter to stop the clock!");
            Console.ReadLine();
        }
    }
    public class ClockEvent
    {
        public Clock clock ;
        public ClockEvent(Clock c)
        {
            clock = c;
            clock.TimerCB += Tick;  //事件的订阅
            clock.TimerCB += Alarm; //事件的订阅
        }
        //为clock事件添加两个处理方法
        static void Tick(object state)
        {
            Console.WriteLine("Tick...Time is: {0}", DateTime.Now.ToLongTimeString());
        }
        static void Alarm(object state)
        {
            if (DateTime.Now.ToLongTimeString().Equals(state))
            {
                Console.WriteLine("Alarm! It' s {0}", DateTime.Now.ToLongTimeString());
            }
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set the alarm by inputting xx:xx:xx!");
            string alarmTime = Console.ReadLine();
            Clock clock = new Clock();
            ClockEvent b = new ClockEvent(clock);
            clock.Do(alarmTime);
        }
    }

}
