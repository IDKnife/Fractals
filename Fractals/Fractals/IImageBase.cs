using System.Drawing;
using System.Threading.Tasks;

namespace Fractals
{
    /// <summary>
    /// Интерфейс базового изображения.
    /// </summary>
    public interface IImageBase
    {
        /// <summary>
        /// Осуществляет создание изображения.
        /// </summary>
        /// <returns>Готовое изображение</returns>
        Bitmap Draw();

        /// <summary>
        /// Осуществляет ассинхронное создание изображения.
        /// </summary>
        /// <returns></returns>
        Task<Bitmap> DrawAsync();

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
