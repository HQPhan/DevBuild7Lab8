using System;

namespace CircleRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            CircleList cl = new CircleList();
            Console.WriteLine("Welcome to the Circle Tester");
            bool goOn = true;
            while (goOn == true)
            {
                
                int radius = cl.GetRadius();
                Circle c = cl.DrawCircles(radius);
                Console.WriteLine(c);
                goOn = cl.Continue();
            }
            Console.WriteLine();
            foreach (Circle circle in cl.Circles)
            {
                Console.WriteLine(circle);
            }
        }
    }
}
