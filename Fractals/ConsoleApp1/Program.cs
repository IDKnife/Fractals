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
            jf.Width = 1024;
            jf.Height = 768;
            var bitmap = jf.Draw();
            bitmap.Save("example.jpg");
        }
    }
}
