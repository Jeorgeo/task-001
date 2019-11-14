using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Sweets
{
    abstract class Sweets
    {
        public string Name { get; private set; }

        public int SugarAmount { get; private set; }

        public int Weight { get; private set; }

    }
}
