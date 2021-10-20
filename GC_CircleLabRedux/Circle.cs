using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CircleLabRedux
{
    class Circle
    {
        public double Radius { get; set; }
        public double Area => Math.Round(Math.PI * Math.Pow(Radius, 2),2); //Listener: don't need Area method // Rounds to 2 decimals
        public double Circumference => Math.Round(2 * Math.PI * Radius,2); //Listener: don't need Circumference method // Rounds to 2 decimals

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override string ToString()
        {
            //Displays all properties formatted.
            //Reserves spacing, and formats for thousands and 2 decimal places
            return $"\n{Radius,-15:n2}\t{Circumference,8:n2}" +
                $"\t{Area,17:n2}";
        }
    }
}
