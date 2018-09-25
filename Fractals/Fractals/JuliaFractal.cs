using System.Drawing;
using System.Numerics;

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
        public int Iterations { get; set; }

        /// <inheritdoc cref="IFractalBase.Zoom"/>
        public double Zoom { get; set; }

        /// <inheritdoc cref="IFractalBase.MoveX"/>
        public double MoveX { get; set; }

        /// <inheritdoc cref="IFractalBase.MoveY"/>
        public double MoveY { get; set; }

        /// <inheritdoc cref="IImageBase.Width"/>
        public int Width { get; set; }

        /// <inheritdoc cref="IImageBase.Height"/>
        public int Height { get; set; }

        /// <inheritdoc cref="IImageBase.R"/>
        public int R { get; set; }

        /// <inheritdoc cref="IImageBase.G"/>
        public int G { get; set; }

        /// <inheritdoc cref="IImageBase.B"/>
        public int B { get; set; }

        /// <inheritdoc cref="IFractalBase.Colors"/>
        public Color[] Colors { get; set; }

        /// <inheritdoc cref="IColorsFactory.GetColors(int, int, int)"/>
        public IColorsFactory ColorsFactory { get; set; }

        /// <inheritdoc cref="IImageBase.Draw"/>
        public Bitmap Draw()
        {
            var fractal = new Bitmap(Width, Height);
            Complex newC, oldC;
            for (var x = 0; x < Width; x++)
                for (var y = 0; y < Height; y++)
                {
                    newC = new Complex(1.5 * (x - Width / 2) / (0.5 * Zoom * Width) + MoveX,
                                                     (y - Height / 2) / (0.5 * Zoom * Height) + MoveY);
                    int i;
                    for (i = 0; i < Iterations; i++)
                    {
                        oldC = newC;
                        newC = new Complex(oldC.Real * oldC.Real - oldC.Imaginary * oldC.Imaginary + C.Real,
                                                                2 * oldC.Real * oldC.Imaginary + C.Imaginary);
                        if ((newC.Real * newC.Real + newC.Imaginary * newC.Imaginary) > 4)
                            break;
                    }
                    fractal.SetPixel(x, y, Colors[i % 256]);
                }
            return fractal;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="JuliaFractal"/> с заданными значениями.
        /// </summary>
        /// <param name="colorsFactory">Фабрика цветов</param>
        public JuliaFractal(IColorsFactory colorsFactory) : this(colorsFactory, 10, 6, 3, 1920, 1080, 1, 300, 0, 0, new Complex(-0.70176, -0.3842))
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="JuliaFractal"/> с базовыми значениями.
        /// </summary>
        public JuliaFractal() : this(new ColorsFactoryBase(), 10, 6, 3, 1920, 1080, 1, 300, 0, 0, new Complex(-0.70176, -0.3842))
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
        protected JuliaFractal(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey, Complex c)
        {
            ColorsFactory = colorsFactory;
            R = r;
            G = g;
            B = b;
            Colors = ColorsFactory.GetColors(R, G, B);
            Width = width;
            Height = height;
            Zoom = zoom;
            Iterations = iterations;
            MoveX = movex;
            MoveY = movey;
            C = c;
        }
    }
}
