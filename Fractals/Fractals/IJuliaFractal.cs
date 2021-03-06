﻿using System.Numerics;

namespace Fractals
{
    /// <summary>
    /// Интерфейс фрактала Жюлиа.
    /// </summary>
    public interface IJuliaFractal : IFractalBase
    {
        /// <summary>
        /// Возвращает комплексное число необходимое для вычислений в алгоритме Жюлиа.
        /// </summary>
        Complex C { get; set; }
    }
}
