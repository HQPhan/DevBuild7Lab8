using System;
using System.Collections.Generic;
using System.Text;

namespace CircleRedux
{
    class CircleList
    {
        //The purpose of this class is to add the circles to the circle list
        public List<Circle> Circles = new List<Circle>();

        public CircleList()
        {

            while (true)
            {
                Console.WriteLine("Enter Radius: ");
                double r = double.Parse(Console.ReadLine());
                if (r > 0)
                {
                    Circle c = new Circle(r);
                    Console.WriteLine(c);
                    break;
                }
                else
                {
                    Console.WriteLine("Please input a number greater than 0");
                }
            }

            //Attempting to create loop to store circles in a list and display how many circles user input
            //int count = 0;
            //for (int i = 0; i < Circles.Count; i++)
            //{                
            //    Circles.Add(new Circle(c.Radius));
            //    Console.WriteLine();
            //    count++;
            //}



        }
        
        //Asking user if they want to continue
        public bool Continue()
        {
            Console.WriteLine("Continue? (y/n)");
            string input = Console.ReadLine().ToLower().Trim();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("Please input 'y' or 'n'!");
                return Continue();
            }
        }

    }
}
