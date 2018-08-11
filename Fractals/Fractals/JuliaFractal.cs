using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    public class JuliaFractal : IJuliaFractal
    {
        public Complex C { get; set; }
        public int Iterations { get; set; }
        public double Zoom { get; set; }
        public double MoveX { get; set; }
        public double MoveY { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Color[] GetColors()
        {
            Color[] _colors;
            _colors = Enumerable.Range(0, 256).Select(c => Color.FromArgb(((c & R) * 85) % 256, ((c >> G) * 36) % 256, ((c >> R & B) * 36) % 256)).ToArray();
            return _colors;
        }

        public Bitmap Draw()
        {
            Color[] _colors = GetColors();
            Bitmap fractal = new Bitmap(Width, Height);

            C = new Complex(-0.70176, -0.3842);
            Zoom = 1;
            MoveX = 0;
            MoveY = 0;
            Iterations = 300;


            //"перебираем" каждый пиксель
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                {
                    //вычисляется реальная и мнимая части числа z
                    //на основе расположения пикселей,масштабирования и значения позиции
                    Complex newC = new Complex(1.5 * (x - Width / 2) / (0.5 * Zoom * Width) + MoveX,
                                                     (y - Height / 2) / (0.5 * Zoom * Height) + MoveY);

                    //i представляет собой число итераций 
                    int i;

                    //начинается процесс итерации
                    for (i = 0; i < Iterations; i++)
                    {
                        Complex oldC = newC;


                        // в текущей итерации вычисляются действительная и мнимая части 
                        newC = new Complex(oldC.Real * oldC.Real - oldC.Imaginary * oldC.Imaginary + C.Real,
                                                                2 * oldC.Real * oldC.Imaginary + C.Imaginary);

                        // если точка находится вне круга с радиусом 2 - прерываемся
                        if ((newC.Real * newC.Real + newC.Imaginary * newC.Imaginary) > 4) break;
                    }


                    fractal.SetPixel(x, y, _colors[i % 256]);
                }
            


            return fractal;
        }
    }
}
