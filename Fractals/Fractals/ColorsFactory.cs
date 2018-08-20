using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractals
{
    /// <summary>
    /// Представляет экземпляр фабрики цветов.
    /// </summary>
    public class ColorsFactory : IColorsFactory
    {
        /// <inheritdoc cref="IColorsFactory.GetColors"/>
        public Color[] GetColors(int R, int G, int B)
        {
            Color[] Colors = Enumerable.Range(0, 256)
                     .Select(c => Color.FromArgb(((c & R) * 85) % 256, ((c >> G) * 36) % 256, ((c >> R & B) * 36) % 256))
                     .ToArray();
            return Colors;
        }
    }
}
