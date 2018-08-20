using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    /// <summary>
    /// Представляет экземпляр фрактала Мандельброта.
    /// </summary>
    public class MandelbrotFractal : IMandelbrotFractal
    {
        /// <inheritdoc cref="IFractalBase.Iterations"/>
        public int Iterations { get; set; }

        /// <inheritdoc cref="IFractalBase.Zoom"/>
        public double Zoom { get; set; }

        /// <inheritdoc cref="IFractalBase.MoveX"/>
        public double MoveX { get; set; }

        /// <inheritdoc cref="IFractalBase.MoveY"/>
        public double MoveY { get; set; }

        /// <inheritdoc cref="IBaseImage.Width"/>
        public int Width { get; set; }

        /// <inheritdoc cref="IBaseImage.Height"/>
        public int Height { get; set; }

        /// <inheritdoc cref="IBaseImage.R"/>
        public int R { get; set; }

        /// <inheritdoc cref="IBaseImage.G"/>
        public int G { get; set; }

        /// <inheritdoc cref="IBaseImage.B"/>
        public int B { get; set; }

        /// <inheritdoc cref="IFractalBase.Colors"/>
        public Color[] Colors { get; set; }

        /// <inheritdoc cref="IColorsFactory.GetColors(int, int, int)"/>
        public IColorsFactory ColorsFactory { get; set; }

        /// <inheritdoc cref="IBaseImage.Draw"/>
        public Bitmap Draw()
        {
            Bitmap fractal = new Bitmap(Width, Height);
            Complex C;
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    C = new Complex((x - Width / 2) / (0.25 * Zoom * Width) + MoveX,
                                    (y - Height / 2) / (0.25 * Zoom * Height) + MoveY);
                    Complex newC = new Complex(0, 0);
                    int i = 0;
                    do
                    {
                        i++;
                        Complex oldC = newC;
                        newC = new Complex(oldC.Real * oldC.Real - oldC.Imaginary * oldC.Imaginary + C.Real,
                                                                2 * oldC.Real * oldC.Imaginary + C.Imaginary);
                        if (Math.Sqrt((newC.Real * newC.Real + newC.Imaginary * newC.Imaginary)) > 2) break;
                    }
                    while (i < Iterations);
                    fractal.SetPixel(x, y, Colors[i % 256]);
                }
            }
            return fractal;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractal"/> с заданными значениями.
        /// </summary>
        /// <param name="colorsFactory">Фабрика цветов</param>
        public MandelbrotFractal(IColorsFactory colorsFactory)
        {
            ColorsFactory = colorsFactory;
            R = 1;
            G = 1;
            B = 1;
            Colors = ColorsFactory.GetColors(R,G,B);
            Width = 1366;
            Height = 768;
            Zoom = 1;
            Iterations = 100;
            MoveX = 0;
            MoveY = 0;
        }
    }
}
