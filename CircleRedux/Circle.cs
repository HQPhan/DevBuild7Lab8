using System;
using System.Collections.Generic;
using System.Text;

namespace CircleRedux
{
    class Circle
    {
        //The purpose of this class is have properties for radius and calculate circuference and area      
        public double Radius { get; set; }

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

        //The methods below automatically updates area and circumference if radius is updated
        public double circumference => Math.Round((2 * Math.PI * Radius), 2);
        //public double CalculateCircumference(double radius)
        //{
        //    double cc = Math.Round((2 * Math.PI * radius),2);
        //    return cc;
        //}

        public double area => Math.Round((Math.PI * Radius * Radius), 2);
        //public double CalculateArea(double radius)
        //{
        //    double area = Math.Round((Math.PI * radius * radius),2);
        //    return area;
        //}
    }


}
