using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fractals
{
    /// <summary>
    /// Интерфейс фрактала Мандельброта.
    /// </summary>
    interface IMandelbrotFractal : IFractalBase
    {
        /// <summary>
        /// Возвращает комплексное число необходимое для вычислений в алгоритме Мандельброта.
        /// </summary>
        Complex C { get; set; }
    }
}
