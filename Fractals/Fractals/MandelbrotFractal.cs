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
        public MandelbrotFractal(IColorsFactory colorsFactory)
        {
            ColorsFactory = colorsFactory;
            R = 5;
            G = 1;
            B = 1;
            Colors = ColorsFactory.GetColors(R, G, B);
            Width = 1920;
            Height = 1080;
            Zoom = 1;
            Iterations = 300;
            MoveX = -0.5;
            MoveY = 0;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MandelbrotFractal"/> с базовыми значениями.
        /// </summary>
        public MandelbrotFractal()
        {
            ColorsFactory = new ColorsFactoryBase();
            R = 5;
            G = 1;
            B = 1;
            Colors = ColorsFactory.GetColors(R, G, B);
            Width = 1920;
            Height = 1080;
            Zoom = 1;
            Iterations = 300;
            MoveX = -0.5;
            MoveY = 0;
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
        public MandelbrotFractal(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey)
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
