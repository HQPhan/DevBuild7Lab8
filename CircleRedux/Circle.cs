using System;
using System.Collections.Generic;
using System.Text;

namespace CircleRedux
{
    public class Circle
    {
        //The purpose of this class is have properties for radius and calculate circuference and area      
        public double Radius { get; set; }
        public double circumference => Math.Round((2 * Math.PI * Radius), 2);
        public double area => Math.Round((Math.PI * Radius * Radius), 2);
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override string ToString()
        {
            string output = $"Circuference: {circumference}\n";
            output += $"Area: {area}\n";
            return output;
        }


    }


}
