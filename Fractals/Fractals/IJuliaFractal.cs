﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fractals
{
    interface IJuliaFractal : IFractalBase
    {
        Complex C { get; set; }
    }
}
