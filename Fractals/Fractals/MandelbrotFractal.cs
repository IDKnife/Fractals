using System.Drawing;
using System.Numerics;

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
        public MandelbrotFractal(IColorsFactory colorsFactory) : this(colorsFactory, 1, 1, 1, 1920, 1080, 1, 300, -0.5, 0)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractal"/> с базовыми значениями.
        /// </summary>
        public MandelbrotFractal() : this(new ColorsFactoryBase(), 1, 1, 1, 1920, 1080, 1, 300, -0.5, 0)
        {
            // ToDo: вынести значения по умолчанию в константу
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
        protected MandelbrotFractal(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey)
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
        }
    }
}
