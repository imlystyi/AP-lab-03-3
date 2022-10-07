// Lab_03_3.cs
// Якубовський Владислав
// Лабораторна робота № 3.3
// Розгалуження, задане графіком функції.
// Варіант 24
using System;

namespace AP_Lab_03_3
{
    internal class Lab_03_3
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть змінні \"x\" та \"R\" по черзі через крапку з комою: ");

            string[] varArray = Console.ReadLine().Split(';');

            double x = Double.Parse(varArray[0].Replace('.', ',')), 
                R = Double.Parse(varArray[1].Replace('.', ','));

            /* x < 0 -> y = (-R/6 * x) - R;
             * 0 < x < R -> y = sqrt(R^2 - x^2);
             * R < x < 2R -> y = sqrt(R^2 - (x - 2R)^2)
             * x > 2R -> y = R. */
            double y;

            if (x < 0)
                y = (-R / 6 * x) - R;

            else if (x > 0 && x < R)
                y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));

            else if (x > R && x < (2 * R))
                y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x - (2 * R), 2));

            else y = R;

            // Частина виведення.
            Console.Write($"Отримане значення для \"y\": {y}");

            Console.ReadLine();
        }
    }
}
