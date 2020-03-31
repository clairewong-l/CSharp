using System;

namespace ForEach
{
    class MainClass
    {
        static void Main(string[] args)
        {
            GenericList<int> genericList = new GenericList<int>();
            int sum = 0,max,min;
            Random rd = new Random();
       
            for(int i=0;i<10;i++)
            {
                genericList.Add(rd.Next(1,100));
            }
            max = genericList.Head.Data;
            min = genericList.Head.Data;
            Action<int> show = m => { Console.WriteLine(m); };
            Action<int> getMax = m => { if (m > max) max = m; };
            Action<int> getMin = m => { if (m < min) min = m; };
            Action<int> getSum = m => sum += m; ;
            genericList.ForEach(show);
            genericList.ForEach(getMax);
            genericList.ForEach(getMin);
            genericList.ForEach(getSum);
            Console.WriteLine($"max={max}");
            Console.WriteLine($"min={min}");
            Console.WriteLine($"sum={sum}");
        }
    }

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
       
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> p = this.head;
            for (; p != null; p = p.Next)
            {
                action(p.Data);
            }
        }
    }
}
