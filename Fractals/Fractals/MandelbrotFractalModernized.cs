using System.Numerics;
using FastBitmapLib;
using System.Linq;

namespace Fractals
{
    /// <summary>
    /// Представляет экземпляр модернизированного фрактала Мандельброта.
    /// </summary>
    public class MandelbrotFractalModernized : MandelbrotFractal
    {
        /// <inheritdoc cref="FractalBase.DrawInner"/>
        protected override void DrawInner(FastBitmap fractal)
        {
            Enumerable.Range(0, Width * Height).AsParallel().ForAll(xy =>
            {
                Complex C, newC, oldC;
                int x = xy % Width, y = xy / Width, i = 0;
                C = new Complex((x - Width / 2) / (0.5 * Zoom * Width) + MoveX,
                                    (y - Height / 2) / (0.5 * Zoom * Height) + MoveY);
                newC = new Complex(0, 0);
                for (; i < Iterations; i++)
                {
                    oldC = newC;
                    newC = new Complex(oldC.Real * oldC.Real - oldC.Imaginary * oldC.Imaginary + C.Real,
                                                            2 * oldC.Real * oldC.Imaginary + C.Imaginary);
                    if ((newC.Real * newC.Real - newC.Imaginary * newC.Imaginary) > 4)
                        break;
                }
                fractal.SetPixel(x, y, Colors[i % 256]);
            });
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractalModernized"/> с заданным значением фабрики цветов.
        /// </summary>
        /// <param name="colorsFactory">Фабрика цветов</param>
        public MandelbrotFractalModernized(IColorsFactory colorsFactory) : base(colorsFactory)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractalModernized"/> с базовыми значениями.
        /// </summary>
        public MandelbrotFractalModernized() : base()
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractalModernized"/> с заданными значениями.
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
        protected MandelbrotFractalModernized(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey) : base(colorsFactory, r, b, g, width, height, zoom, iterations, movex, movey)
        {
        }
    }
}
