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
        /// <inheritdoc cref="IMandelbrotFractal.C"/>
        public Complex C { get; set; }

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

        /// <inheritdoc cref="IFractalBase.GetColors"/>
        public Color[] GetColors()
        {
            Color[] _colors;
            _colors = Enumerable.Range(0, 256).Select(c => Color.FromArgb(((c & R) * 85) % 256, ((c >> G) * 36) % 256, ((c >> R & B) * 36) % 256)).ToArray();
            return _colors;
        }

        /// <inheritdoc cref="IBaseImage.Draw"/>
        public Bitmap Draw()
        {
            Color[] _colors = GetColors();
            Bitmap fractal = new Bitmap(Width, Height);
            Zoom = 1;
            MoveX = 0;
            MoveY = 0;
            Iterations = 100;
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    C = new Complex((x - Width / 2) / (0.25 * Zoom * Width) + MoveX,
                                    (y - Height / 2) / (0.25 * Zoom * Height) + MoveY);
                    Complex newC = new Complex(0,0);
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
                    fractal.SetPixel(x, y, _colors[i % 256]);
                }
            }
            return fractal;
        }
    }
}
