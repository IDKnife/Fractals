using System.Linq;
using System.Drawing;

namespace Fractals
{
    /// <inheritdoc/>
    public class ColorsFactoryBase : IColorsFactory
    {
        /// <inheritdoc cref="IColorsFactory.GetColors"/>
        public Color[] GetColors(int R, int G, int B)
        {
            return Enumerable.Range(0, 256)
                             .Select(c => Color.FromArgb(((c & R) * 85) % 256, ((c >> G) * 36) % 256, ((c >> R & B) * 36) % 256))
                             .ToArray();
        }
    }
}
