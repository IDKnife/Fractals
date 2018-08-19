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
            JuliaFractal jf = new JuliaFractal();
            MandelbrotFractal mf = new MandelbrotFractal();
            jf.Width = 1366;
            jf.Height = 768;
            var bitmap = jf.Draw();
            bitmap.Save("example3.jpg");
            mf.Width = 1366;
            mf.Height = 768;
            var bitmap2 = mf.Draw();
            bitmap2.Save("example4.jpg");
        }
    }
}
