using System.Drawing;
using Fractals;

namespace FractalsForm
{
    /// <summary>
    /// Экземпляр модели данных фрактала. 
    /// </summary>
    class FractalViewModel
    {
        /// <summary>
        /// Изображение фрактала.
        /// </summary>
        public Bitmap Image { get; set; }

        /// <summary>
        /// Фрактал.
        /// </summary>
        public IFractalBase Fractal { get; set; }
    }
}
