using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razrab_PO
{
    /// <summary>Class of Rectangle</summary>
    /// <seealso cref="Razrab_PO.Figure" />
    public class Rectangle : Figure
    {
        public Rectangle() : base(0, 0, "Прямоугольник") { }

        public double Diagonal()
        {
            Console.WriteLine($"диагональ прямоугольника равна {Math.Sqrt(this.x * this.x + this.y * this.y)}");
            return Math.Sqrt(this.x * this.x + this.y * this.y);
        }

        public bool Is_square()
        {
            if (this.x == this.y)
            {
                Console.WriteLine("Это квадрат");
                return true;
            }
            else
            {
                Console.WriteLine("Это НЕ квадрат");
                return false;
            }
        }

        public override double Area()
        {
            Console.WriteLine($"Площадь прямоугольника равна {this.x * this.y}");
            return this.x * this.y;
        }

        public override double Perimeter()
        {
            Console.WriteLine($"Периметр прямоугольника равен {2 * (this.x + this.y)}");
            return 2 * (this.x + this.y);
        }

        public bool Is_Perimeter_more_then_Area() 
        {
            if (Perimeter() > Area())
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
    }
}
