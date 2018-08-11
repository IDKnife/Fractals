using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractals
{
    interface IFractalBase : IBaseImage
    {
        int Iterations { get; set; }
        double Zoom { get; set; }
        Color[] GetColors();
        double MoveX { get; set; }
        double MoveY { get; set; }
    }
}
