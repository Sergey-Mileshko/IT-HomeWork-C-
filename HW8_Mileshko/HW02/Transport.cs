﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_02_Mileshko
{
    public abstract class Transport
    {
        public Engine Engine { get; set; }
        public abstract void Move();
    }
}
