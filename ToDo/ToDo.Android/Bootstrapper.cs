﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Droid
{
    public class Bootstrapper : ToDo.Bootstrapper
    {
        public static void Init()
        {
            _ = new Bootstrapper();
        }
    }
}
