using System;

namespace GC_CircleLabRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            BagOfCircles Circles = new BagOfCircles();
            bool userContinue = true;
            //Simple menu system
            while (userContinue)
            {
                string input = GetInput("\n::MENU::" +
                    "\n1) Add Circle" +
                    "\n2) Print Circles" +
                    "\n3) Exit" +
                    "\n:: ");
                switch (input)
                {
                    case "1":
                        Circles.CreateCircle();
                        break;

                    case "2":
                        Circles.DisplayBag();
                        break;

                    case "3":
                        userContinue = false;
                        Console.WriteLine("\n::GOODBYE::");
                        break;
                    default:
                        Console.WriteLine("\n~INVALID INPUT: Select a number from the menu~");
                        break;
                }
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
