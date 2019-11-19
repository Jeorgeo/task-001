using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Sweets
{
    public class Cakes : Sweet
    {
        public Cakes(string name, int sugarAmount, int weight)
        {
            Name = name;

            SugarAmount = sugarAmount;

            Weight = weight;
        }

        enum CakesType {Сookie, Cake, Waffles};

        public int flourAmount;

        protected int FlourAmount
        {
            get; private set;
        }

        public override void DetermineSugar()
        {
            var c = SugarAmount * Weight * 0.7 / 100;
            Console.WriteLine(c);
        }

    }
        
    
}
