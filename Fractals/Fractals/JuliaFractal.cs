using System.Numerics;
using FastBitmapLib;
using System.Linq;

namespace Fractals
{
    /// <summary>
    /// Представляет экземпляр фрактала Жюлиа.
    /// </summary>
    public class JuliaFractal : FractalBase, IJuliaFractal
    {
        private const double C_RE_CONST = -0.70176;
        private const double C_IM_CONST = -0.3842;
        /// <inheritdoc cref="IJuliaFractal.C"/>
        public Complex C { get; set; }

        /// <inheritdoc cref="FractalBase.DrawInner"/>
        protected override void DrawInner(FastBitmap fractal)
        {
            Enumerable.Range(0, Width * Height).AsParallel().ForAll(xy =>
              {
                  Complex newC, oldC;
                  int x = xy % Width, y = xy / Width, i = 0;
                  newC = new Complex(1.5 * (x - Width / 2) / (0.5 * Zoom * Width) + MoveX,
                                                   (y - Height / 2) / (0.5 * Zoom * Height) + MoveY);
                  for (; i < Iterations; i++)
                  {
                      oldC = newC;
                      newC = new Complex(oldC.Real * oldC.Real - oldC.Imaginary * oldC.Imaginary + C.Real,
                                                              2 * oldC.Real * oldC.Imaginary + C.Imaginary);
                      if ((newC.Real * newC.Real + newC.Imaginary * newC.Imaginary) > 4)
                          break;
                  }
                fractal.SetPixel(x, y, Colors[i % 256]);
              });
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="JuliaFractal"/> с заданным значением фабрики цветов.
        /// </summary>
        /// <param name="colorsFactory">Фабрика цветов</param>
        public JuliaFractal(IColorsFactory colorsFactory) : base(colorsFactory)
        {
            C = new Complex(C_RE_CONST, C_IM_CONST);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="JuliaFractal"/> с базовыми значениями.
        /// </summary>
        public JuliaFractal() : this(new ColorsFactoryBase())
        {
        }

        /// <summary>
        ///  Инициализирует новый экземпляр класса <see cref="JuliaFractal"/> с заданными значениями.
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
        /// <param name="c">Комплексное число для алгоритма Жюлиа</param>
        protected JuliaFractal(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey, Complex c) : base(colorsFactory, r, b, g, width, height, zoom, iterations, movex, movey)
        {
            C = c;
        }
    }
}
