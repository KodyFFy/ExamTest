using static System.Math;

namespace SampleText
{
    public static class Figures
    {
        public static double triangle(double Cathet1, double Cathet2, double Hypotenuse) // Треугольник
        {
            double Area;
            double p = (Cathet1 + Cathet2 + Hypotenuse)/2;

            Area = Math.Round(Math.Sqrt(p * (p - Cathet1) * (p - Cathet2) * (p - Hypotenuse)), 4);

            if (Math.Pow(Hypotenuse, 2) == (Math.Pow(Cathet1, 2) + Math.Pow(Cathet2, 2)))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
            Console.WriteLine($"Площадь: {Area}");
            return Area;
        }

        public static double circle(double Radius) // Круг
        {
            double Area;
            Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 4);
            Console.WriteLine($"Площадь круга: {Area}");
            return Area;
        }


        public static double unknownFigure(double Cathet1, double Cathet2, double Hypotenuse)
        {
            return triangle(Cathet1, Cathet2, Hypotenuse);
        }

        public static double unknownFigure(double Radius)
        {  
            return circle(Radius);
        }


        public static double unknownFigure(string figure)
        {
            bool power = false;
            int count = 0;

            double[] mass = new double[30];

            Console.WriteLine("Введите длины сторон фигуры (для отмены ввода введите !)");
            while (power == false)
            {
                double num = Convert.ToDouble(Console.ReadLine());

                mass.Append(num);

                count += 1;
            }



            return count;
        }


      /*public static void FunctionName(double a, ..., double z)
       * {
       * double Area;
       * 
       * ...
       * 
       * Console.WriteLine($"Площадь фигруы: {Area}");
       * } */

    }
}
