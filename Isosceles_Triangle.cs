using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razrab_PO
{
    /// <summary>Class of Isosceles_triangle</summary>
    /// <seealso cref="Razrab_PO.Figure" />
    public class Isosceles_Triangle : Figure
    {
        public Isosceles_Triangle() : base(0, 0, "Равнобедренный треугольник") { }
        // параметр а - длина одной из равных сторон
        public double Height ()
        {
            return Math.Sqrt(this.x * this.x - this.y * this.y / 4);
        }

        public bool Is_equilateral()
        {
            if (this.x == this.y)
            {
                Console.WriteLine("Этот треугольник равносторонний");
                return true;
            }
            else
            {
                Console.WriteLine("Этот треугольник НЕ равносторонний");
                return false;
            }
        }

        public override double Area()
        {
            Console.WriteLine($"Площадь равнобедренного треугольника равна {0.5 * this.y * Height()}");
            return 0.5 * this.y * Height();
        }

        public override double Perimeter()
        {
            Console.WriteLine($"Периметр равнобедренного треугольника равен {2 * this.x + this.y}");
            return 2 * this.x + this.y;
        }

        public bool Is_Perimeter_more_then_Area()
        {
            if(Perimeter() > Area())
            {
                Console.WriteLine("Периметр больше площади");
                return true;
            }
            else
            {
                Console.WriteLine("Периметр меньше площади");
                return false;
            }
        }
        public double Param_diff()
        {
            if (this.x > this.y)
            {
                Console.WriteLine("Боковая сторона больше");
            }
            else
            {
                Console.WriteLine("Основание больше");
            }
            Console.WriteLine($"Разница: {Math.Abs(this.x - this.y)}");
            return Math.Abs(this.x - this.y);
        }

        public double Double_size_area()
        {
            Console.WriteLine($"Площадь треугольника, большего в 2 раза, равна {2 * this.y * Height()}");
            return 2 * this.y * Height();
        }

        public double Circle_radius()
        {
            double p = Perimeter() / 2;
            double r = Math.Sqrt((p - this.x) * (p - this.x) * (p - this.y) / p);
            Console.WriteLine($"Радиус вписанной окружности равен {r}");
            return r;
        }
    }
}
