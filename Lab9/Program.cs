using System;
using System.Collections.Generic;

namespace Lab9
{
    class Program
    {
        static void Main()
        {
            double radius = 0;
            bool continuey = true;
            List<Circle> allTheCicles = new List<Circle>();
            while (continuey == true)
            {
                Console.WriteLine("Hello, Please give me the radius of a Circle you'd like to create");
                string radiusInput = Console.ReadLine();
                bool valid = double.TryParse(radiusInput, out radius);
                if (valid == false || radius <= 0)
                {
                    Console.WriteLine("This is not a valid input for radius");
                    Main();
                }

                Circle circle = new Circle(radius);
                allTheCicles.Add(circle);

                Console.WriteLine("Would you like to continue? y/n");
                string moreCircles = Console.ReadLine().ToLower();
                if (moreCircles == "y" || moreCircles == "yes")
                {

                }
                else if (moreCircles == "n" || moreCircles == "no")
                {
                    Console.WriteLine("Thanks, have a nice day! You made this many circles:");
                    Console.WriteLine(allTheCicles.Count);
                    continuey = false;
                }
                else
                {
                    Console.WriteLine("I do not understand, terminating program");
                    continuey = false;
                }
            }

        }
    }
}
