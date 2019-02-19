using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
    /// <summary>
    /// Представляет абстрактный экземпляр базового фрактала.
    /// </summary>
    public abstract class FractalBase : IFractalBase
    {
        private const int ITERATIONS = 300;
        private const int R_CONST = 1;
        private const int B_CONST = 1;
        private const int G_CONST = 1;
        private const int WIDTH = 1920;
        private const int HEIGHT = 1080;
        private const double ZOOM = 1;
        private const double MOVEX = 0;
        private const double MOVEY = 0;

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
        abstract public Bitmap Draw();

        /// <summary>
        ///  Инициализирует новый экземпляр класса <see cref="FractalBase"/> с заданными значениями.
        /// </summary>
        /// <param name="colorsFactory">Фабрика цветов</param>
        public FractalBase(IColorsFactory colorsFactory) : this(colorsFactory, R_CONST, B_CONST, G_CONST, WIDTH, HEIGHT, ZOOM, ITERATIONS, MOVEX, MOVEY)
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="FractalBase"/> с базовыми значениями.
        /// </summary>
        public FractalBase() : this(new ColorsFactoryBase(), R_CONST, B_CONST, G_CONST, WIDTH, HEIGHT, ZOOM, ITERATIONS, MOVEX, MOVEY)
        {
        }

        /// <summary>
        ///  Инициализирует новый экземпляр класса <see cref="FractalBase"/> с заданными значениями.
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
        protected FractalBase(IColorsFactory colorsFactory, int r, int b, int g, int width, int height, double zoom, int iterations, double movex, double movey)
        {
            ColorsFactory = colorsFactory;
            R = r;
            G = g;
            B = b;
            Width = width;
            Height = height;
            Zoom = zoom;
            Iterations = iterations;
            MoveX = movex;
            MoveY = movey;
        }
    }
}
