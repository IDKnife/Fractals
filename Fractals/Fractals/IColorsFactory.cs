using System.Drawing;

namespace Fractals
{
    /// <summary>
    /// Интерфейс фабрики цветов.
    /// </summary>
    public interface IColorsFactory
    {
        /// <summary>
        /// Возвращает массив цветов.
        /// </summary>
        /// <returns>Массив цветов</returns>
        Color[] GetColors(int R, int G, int B);
    }
}
