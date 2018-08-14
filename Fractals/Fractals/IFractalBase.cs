using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractals
{
    /// <summary>
    /// Интерфейс базового фрактала.
    /// </summary>
    interface IFractalBase : IBaseImage
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
        Color[] GetColors();

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
