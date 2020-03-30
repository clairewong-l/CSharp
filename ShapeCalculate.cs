using System;

namespace ShapeCalculate
{
    //形状接口
    public interface Shape
    {
        void getLength();
        double ShapeArea();
        bool ifProper();
    }
    //长方形类
    class Rectangle : Shape
    {
        protected double[] SideLength = new double[4];

        public void getLength()
        {
            Console.WriteLine("请输入四条边长度：");
            for (int i = 0; i < SideLength.Length; i++)
                SideLength[i] = double.Parse(Console.ReadLine());
        }
        public bool ifProper()
        {
            /*
             * for (int i = 0; i < 4; i++)
                for (int j = i + 1; j < 4; j++)
                {
                    if (SideLength[i] == SideLength[j] && SideLength[3 - i] == SideLength[3 - j])
                    {
                        return true;
                    }
                }
                */
            Array.Sort(SideLength);
            if(SideLength[0]==SideLength[1]&&SideLength[2]==SideLength[3])
                return true;
            else
                return false;
        }
        public double ShapeArea()
        {
            Array.Sort(SideLength);
            if (this.ifProper())
            {
                /*if (SideLength[0] == SideLength[1])
                    return SideLength[0] * SideLength[2];
                else return SideLength[0] * SideLength[1];*/
                return SideLength[0] * SideLength[2];
            }
            else
                return 0;
        }
    }
    //正方形类
    class Cube : Rectangle
    {
        new public bool ifProper()
        {
            Array.Sort(SideLength);
            if (SideLength[0] == SideLength[3])
                return true;
            else
                return false;
        }
    }
    //三角形类
    class Triangle : Shape
    {
        protected int[] SideLength = new int[3];
        public void getLength()
        {
            Console.WriteLine("请输入三条边长度：");
            for (int i = 0; i < SideLength.Length; i++)
                SideLength[i] = int.Parse(Console.ReadLine());
        }
        public bool ifProper()
        {
            if (SideLength[0] + SideLength[1] > SideLength[2]
                && SideLength[0] + SideLength[2] > SideLength[1]
                && SideLength[1] + SideLength[2] > SideLength[0])
                return true;
            else return false;
        }
        public double ShapeArea()
        {
            double p, S;
            if (this.ifProper())
            {
                p = (SideLength[0] + SideLength[1] + SideLength[2]) / 2;
                S = System.Math.Sqrt(p * (p - SideLength[0])
                    * (p - SideLength[1]) * (p - SideLength[2]));
                return S;
            }
            else return 0;
        }
    }

    //工厂类
    public class ShapeFactory
    {
        public static Shape createShape(string type)
        {
            Shape shape=null;
            switch (type) {
                case "Rectangle":
                    shape = new Rectangle();
                    break;
                case "Cube":
                    shape = new Cube();break;
                case "Triangle":
                    shape = new Triangle(); break;
                default:
                    Console.WriteLine("Unknown Shape!"); break;
            }
            return shape;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        { 
            int count = 0;
            string type;
            double sum = 0;
            while (count < 10)
            {
                Shape shape;
                Console.WriteLine("请输入需要创建的图形：Rectangle/Cube/Triangle");
                type = Console.ReadLine();
                while((shape = ShapeFactory.createShape(type))!=null)
                {
                    shape.getLength();
                    if (shape.ifProper())
                    {
                        sum += shape.ShapeArea();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("图形不正确,请重新输入");
                        continue;
                    }
                }
                count++;
            }
            Console.WriteLine("10个图形总面积为{0}", sum);

        }
    }
}

