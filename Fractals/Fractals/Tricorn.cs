using System.Drawing;
using System.Numerics;

namespace Fractals
{
    /// <summary>
    /// Представляет экземпляр фрактала Трикорн.
    /// </summary>
    public class Tricorn : MandelbrotFractal
    {
        /// <inheritdoc cref="FractalBase.DrawInner"/>
        protected override void DrawInner(Bitmap fractal)
        {
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
                                                                -2 * oldC.Real * oldC.Imaginary + C.Imaginary);
                        if ((newC.Real * newC.Real + newC.Imaginary * newC.Imaginary) > 4)
                            break;
                    }
                    while (i < Iterations);
                    fractal.SetPixel(x, y, Colors[i % 256]);
                }
            }
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tricorn"/> с заданным значением фабрики цветов.
        /// </summary>
        /// <param name="colorsFactory">Фабрика цветов</param>
        public Tricorn(IColorsFactory colorsFactory) : base(colorsFactory)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tricorn"/> с базовыми значениями.
        /// </summary>
        public Tricorn() : base()
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Tricorn"/> с заданными значениями.
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
        protected Tricorn(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey) : base(colorsFactory, r, b, g, width, height, zoom, iterations, movex, movey)
        {
        }
    }
}
