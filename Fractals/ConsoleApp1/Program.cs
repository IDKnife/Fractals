using System.Diagnostics;
using Fractals;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IColorsFactory colorsFactory = new ColorsFactoryBase(); 
            JuliaFractal jf = new JuliaFractal(colorsFactory);
            MandelbrotFractal mf = new MandelbrotFractal(colorsFactory);
            //var bitmap = jf.Draw();
            //bitmap.Save("example3.jpg");
            var bitmap2 = mf.Draw();
            bitmap2.Save("example4.jpg");
            Process.Start("example4.jpg");
        }
    }
}
