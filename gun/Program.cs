using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ПУШКА\n\nВведите координаты пушки\nx = ");
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
            Console.Write("\nВведите момент времени, в котором вы хотите узнать координаты снаряда\nt = ");
            double t = Convert.ToInt32(Console.ReadLine());
                if (t < 0)
                    Console.WriteLine("\nВремя не может быть отрицательным! Пожалуйста, попробуйте ещё раз");
                else
                {
                    double Vx0 = V0 * Math.Cos((a * Math.PI) / 180);
                    double Vy0 = V0 * Math.Sin((a * Math.PI) / 180);
                    double x = Math.Round(x0 + Vx0 * t, 2);
                    double y = Math.Round(y0 + Vy0 * t - (9.81 * Math.Pow(t, 2)) / 2, 2);
                    if (y >= 0)
                        Console.WriteLine($"\nx = {x}\ny = {y}");
                    else
                    {
                        t = (Vy0 + Math.Sqrt(Math.Pow(Vy0, 2) + 2 * 9.81 * y0)) / 9.81;
                        x = Math.Round(x0 + Vx0 * t, 2);
                        y = 0;
                        Console.WriteLine($"\nx = {x}\ny = {y}");
                    }
                }
            }
        }
    }
}
