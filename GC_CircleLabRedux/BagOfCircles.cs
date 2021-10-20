using System;
using System.Collections.Generic;

namespace GC_CircleLabRedux
{
    class BagOfCircles
    {
        //List of circles
        public List<Circle> Circles = new List<Circle>();

        public string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        public bool IsNum(string input)
        {
            //Makes sure input is a number and greater then 0
            double num;
            if (double.TryParse(input, out num))
            {
                if (num > 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\n~INVALID INPUT: Must be positive~");
                    return false;
                }
            }
            Console.WriteLine("\n~INVALID INPUT: Must be a number~");
            return false;
        }
        public void CreateCircle()
        {
            //Grabs user input, calls validates, and adds to list
            string input = GetInput("\nPlease enter a radius: ");
            if (IsNum(input))
            {
                Circle c = new Circle(double.Parse(input));
                Console.WriteLine($"\nRadius: {c.Radius:n2}\tCircumference: {c.Circumference:n2}" +
                    $"\tArea: {c.Area:n2}");
                Circles.Add(c);
            }
        }
        public void DisplayBag()
        {
            //Displays all circles in list and how many
            Console.WriteLine("\n{0,-15}{1,15}{2,15}","Radius", "Circumference", "Area");
            Console.WriteLine("==============================================");
            foreach (var item in Circles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nTotal Circles: {Circles.Count}");
        }

    }
}

