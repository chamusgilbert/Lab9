using System;


namespace Lab9
{
    class Circle
    {

        public Circle(double radius)
        {

            double area = CalculateArea(radius);
            double circumference = CalculateCircumference(radius);
            Console.WriteLine("The area of your circle is " + area + ". The circumference of your circle is " + circumference);
        }

        public static double CalculateArea(double radius)
        {
            double area = Math.PI * (radius * radius);
            area = FormatArea(area);
            return area;
        }
        public static double CalculateCircumference(double radius)
        {
            double circumference = (radius + radius) * Math.PI;
            circumference = FormatCircumference(circumference);
            return circumference;
        }
        public static double FormatArea(double a)
        {

            a = Math.Round(a, 2);

            return a;
        }
        public static double FormatCircumference(double c)
        {

            c = Math.Round(c, 2);

            return c;
        }
    }
}
