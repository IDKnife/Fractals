using System.Drawing;
using System.Numerics;

namespace Fractals
{
    /// <summary>
    /// Представляет экземпляр фрактала Мандельброта.
    /// </summary>
    public class MandelbrotFractal : FractalBase, IMandelbrotFractal
    {
        /// <inheritdoc cref="IImageBase.Draw"/>
        public override Bitmap Draw()
        {
            Colors = ColorsFactory.GetColors(R, G, B);
            var fractal = new Bitmap(Width, Height);
            Complex C, newC, oldC;
            for (var x = 0; x < Width; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    C = new Complex((x - Width / 2) / (0.5 * Zoom * Width) + MoveX,
                                    (y - Height / 2) / (0.5 * Zoom * Height) + MoveY);
                    newC = new Complex(0, 0);
                    int i = 0;
                    do
                    {
                        i++;
                        oldC = newC;
                        newC = new Complex(oldC.Real * oldC.Real - oldC.Imaginary * oldC.Imaginary + C.Real,
                                                                2 * oldC.Real * oldC.Imaginary + C.Imaginary);
                        if ((newC.Real * newC.Real + newC.Imaginary * newC.Imaginary) > 4)
                            break;
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
        public MandelbrotFractal(IColorsFactory colorsFactory) : base(colorsFactory)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractal"/> с базовыми значениями.
        /// </summary>
        public MandelbrotFractal() : base()
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractal"/> с заданными значениями.
        /// </summary>
        /// <param name="colorsFactory">Фабрика цветов</param>
        /// <param name="r">Компонент цвета r</param>
        /// <param name="b">Компонент цвета b</param>
        /// <param name="g">Компонент цвета g</param>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        /// <param name="zoom">Увеличение</param>
        /// <param name="iterations">Кол-во итераций</param>
        /// <param name="movex">Смещение по Х</param>
        /// <param name="movey">Смещение по Y</param>
        protected MandelbrotFractal(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey) : base(colorsFactory, r, b, g, width, height, zoom, iterations, movex, movey)
        {
        }
    }
}
