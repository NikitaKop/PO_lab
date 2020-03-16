using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// </summary>
namespace Razrab_PO
{
    public class Program
    {
        public static void Main()
        {
            Rectangle t1 = new Rectangle();
            t1.x = 5;
            t1.y = 8;
            t1.Area();
            t1.Perimeter();
            t1.Is_Perimeter_more_then_Area();
            t1.Is_square();

            Isosceles_Triangle t2 = new Isosceles_Triangle();
            t2.x = 5;
            t2.y = 8;
            t2.Area();
            t2.Perimeter();
            t2.Is_Perimeter_more_then_Area();
            t2.Is_equilateral();

        }
    }

}
