using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fractals;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IColorsFactory colorsFactory = new ColorsFactory(); 
            JuliaFractal jf = new JuliaFractal(colorsFactory);
            MandelbrotFractal mf = new MandelbrotFractal(colorsFactory);
            var bitmap = jf.Draw();
            bitmap.Save("example3.jpg");
            var bitmap2 = mf.Draw();
            bitmap2.Save("example4.jpg");
        }
    }
}
