using System.Drawing;

namespace Fractals
{
    /// <summary>
    /// Интерфейс базового фрактала.
    /// </summary>
    public interface IFractalBase : IImageBase
    {
        /// <summary>
        /// Возвращает количество итераций.
        /// </summary>
        int Iterations { get; set; }

        /// <summary>
        /// Возвращает зум.
        /// </summary>
        double Zoom { get; set; }

        /// <summary>
        /// Возвращает массив цветов.
        /// </summary>
        /// <returns>Массив цветов</returns>
        Color[] Colors { get; set; }
        
        /// <summary>
        /// Возвращает смещение по Х.
        /// </summary>
        double MoveX { get; set; }

        /// <summary>
        /// Возвращает смещение по Y.
        /// </summary>
        double MoveY { get; set; }
    }
}
