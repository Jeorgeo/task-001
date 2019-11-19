using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Sweets
{
    public abstract class Sweet
    {

        public string Name { get; set; }

        public int SugarAmount { get; protected set; }

        public int Weight { get; set; }

        public abstract void DetermineSugar();
    }
}
