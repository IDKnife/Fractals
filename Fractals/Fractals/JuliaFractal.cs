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
    /// Представляет экземпляр фрактала Жюлиа.
    /// </summary>
    public class JuliaFractal : IJuliaFractal
    {
        /// <inheritdoc cref="IJuliaFractal.C"/>
        public Complex C { get; set; }

        /// <inheritdoc cref="IFractalBase.Iterations"/>
        public int Iterations { get ; set; }

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
            C = new Complex(-0.70176, -0.3842);
            Zoom = 1;
            MoveX = 0;
            MoveY = 0;
            Iterations = 300;
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                {
                    Complex newC = new Complex(1.5 * (x - Width / 2) / (0.5 * Zoom * Width) + MoveX,
                                                     (y - Height / 2) / (0.5 * Zoom * Height) + MoveY);
                    int i;
                    for (i = 0; i < Iterations; i++)
                    {
                        Complex oldC = newC;
                        newC = new Complex(oldC.Real * oldC.Real - oldC.Imaginary * oldC.Imaginary + C.Real,
                                                                2 * oldC.Real * oldC.Imaginary + C.Imaginary);
                        if ((newC.Real * newC.Real + newC.Imaginary * newC.Imaginary) > 4) break;
                    }
                    fractal.SetPixel(x, y, _colors[i % 256]);
                }
            return fractal;
        }
    }
}
