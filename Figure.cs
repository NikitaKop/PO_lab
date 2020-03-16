using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razrab_PO
{
    /// <summary>Main class of all figures</summary>
    public class Figure
    {
        /// <summary>  first parameter</summary>
        public double x;
        /// <summary>Second parameter</summary>
        public double y;
        /// <summary>  Name of figure</summary>
        string name;
        /// <summary>Initializes a new instance of the <see cref="Figure"/> class.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        public Figure(double a, double b, string c) { x = a; y = b; name = c; }
        /// <summary>  Count the area</summary>
        /// <returns></returns>
        public virtual double Area() { return -1; }
        /// <summary>  Count the perimeter</summary>
        /// <returns></returns>
        public virtual double Perimeter() { return -1; }
    }
}
