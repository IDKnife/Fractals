using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractals
{

    interface IBaseImage
    {
        Bitmap Draw();
        int Width { get; set; }
        int Height { get; set; }
        int R { get; set; }
        int G { get; set; }
        int B { get; set; }
    }
}
