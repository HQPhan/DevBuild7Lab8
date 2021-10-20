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
                try
                {                    
                    CircleList O = new CircleList();
                    Console.WriteLine(O.Circles);

                    //Console.WriteLine($"Circumference: {Math.Round(c.CalculateCircumference(r),2)}");
                    //Console.WriteLine($"Area: {Math.Round(c.CalculateArea(r),2)}");
                    goOn = O.Continue();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not valid. Please try again!");
                    goOn = true;
                }
            }
        }        
    }
}
