using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Пушка";
            Console.Write("Введите координаты пушки\nx = ");
            int x0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y0 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите начальную скорость снаряда\nV = ");
            int V0 = Convert.ToInt32(Console.ReadLine());
            if (V0 < 0)
                Console.WriteLine("\nСкорость не может быть отрицательной! Пожалуйста, попробуйте ещё раз");
            else
            {
                Console.Write("\nВведите угол вылета снаряда из пушки в градусах\na = ");
                int a = Convert.ToInt32(Console.ReadLine());
                double t = 0;
                double Vx0 = V0 * Math.Cos((a * Math.PI) / 180);
                double Vy0 = V0 * Math.Sin((a * Math.PI) / 180);
                double x = Math.Round(x0 + Vx0 * t, 2);
                double y = Math.Round(y0 + Vy0 * t - (9.81 * Math.Pow(t, 2)) / 2, 2);
                double max_x = x0;
                double max_y = y0;
                Console.WriteLine("\n  X         Y");
                for (t = 0; y >= 0; t++)
                {
                    x = Math.Round(x0 + Vx0 * t, 2);
                    y = Math.Round(y0 + Vy0 * t - (9.81 * Math.Pow(t, 2)) / 2, 2);
                    if (max_y < y)
                    {
                        max_x = x;
                        max_y = y;
                    }
                    if (y >= 0)
                        Console.WriteLine($"{x}\t{y}");
                }
                Console.WriteLine($"\nКоординаты наивысшей точки траектории снаряда: {max_x}\t{max_y}");
            }
        }
    }
}