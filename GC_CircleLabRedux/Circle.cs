using System;
using System.Collections.Generic;
using System.Text;

namespace GC_CircleLabRedux
{
    class Circle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Math.Pow(Radius, 2); //Listener: don't need Area method
        public double Circumference => 2 * Math.PI * Radius; //Listener: don't need Circumference method

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override string ToString()
        {
            //Displays all properties formatted.
            //Rounds to 2 decimals, Reserves spacing, and formats for thousands and 2 decimal places
            return $"\n{Math.Round(Radius,2),-15:n2}\t{Math.Round(Circumference, 2),8:n2}" +
                $"\t{Math.Round(Area, 2),17:n2}";
        }
    }
}
