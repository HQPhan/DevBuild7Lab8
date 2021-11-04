using System;

namespace CircleRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester");
            bool goOn = true;
            while (goOn == true)
            {
                CircleList cl = new CircleList();
                int radius = cl.GetRadius();
                Circle c = cl.DrawCircles(radius);
                Console.WriteLine(c);
                goOn = cl.Continue();
            }
        }
    }
}
