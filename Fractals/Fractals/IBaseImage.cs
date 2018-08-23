using System.Drawing;

namespace Fractals
{
    /// <summary>
    /// Интерфейс базового изображения.
    /// </summary>
    interface IBaseImage
    {
        /// <summary>
        /// Осуществляет создание изображения.
        /// </summary>
        /// <returns>Готовое изображение</returns>
        Bitmap Draw();

        /// <summary>
        /// Возвращает ширину изображения.
        /// </summary>
        int Width { get; set; }

        /// <summary>
        /// Возвращает высоту изображения.
        /// </summary>
        int Height { get; set; }

        /// <summary>
        /// Возвращает параметр R цветовой гаммы изображения.
        /// </summary>
        int R { get; set; }

        /// <summary>
        /// Возвращает параметр G цветовой гаммы изображения.
        /// </summary>
        int G { get; set; }

        /// <summary>
        /// Возвращает параметр B цветовой гаммы изображения.
        /// </summary>
        int B { get; set; }
    }
}
