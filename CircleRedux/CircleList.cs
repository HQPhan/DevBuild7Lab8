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
            
        }
        public int GetRadius()
        {
            Console.Write("Please enter a radius:");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;                
            } 
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                return GetRadius();
            }
        }
        public Circle DrawCircles(int num)
        {
            Circle c = new Circle(num);
            Circles.Add(c); //Add to current Circles List. 
            return c;
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
