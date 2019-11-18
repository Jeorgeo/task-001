using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Sweets
{
    public class Cakes : Sweets
    {
        public string Name { get; private set; }

        public double СarbohydratesAmount { get; private set; }

        public double SugarAmount { get; private set; }

        public int Weight { get; private set; }

        enum CakesType { Сookie, Cake, Waffles };   

        protected double PalmOil { get; private set; }

        public override void DetermineSugarAmount() { 
        


        }

    }
}
