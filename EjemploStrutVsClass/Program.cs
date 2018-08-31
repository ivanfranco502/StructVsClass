namespace EjemploStrutVsClass
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PointClass a = new PointClass(10,10);
            PointClass b = a;
            a.X = 20;
            Console.WriteLine($"a.X:{a.X} - a.Y:{a.Y}");
            Console.WriteLine($"b.X:{b.X} - b.Y:{b.Y}");

            Console.ReadLine();

            PointStruct c = new PointStruct(10, 10);
            PointStruct d = c;
            c.X = 20;
            Console.WriteLine($"c.X:{c.X} - c.Y:{c.Y}");
            Console.WriteLine($"d.X:{d.X} - d.Y:{d.Y}");

            Console.ReadLine();
        }
    }
}
