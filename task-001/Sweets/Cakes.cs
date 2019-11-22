using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Sweets
{
    public class Cakes : Sweet
    {

        public int ProductHumiditly { get; set; }

        public Cakes(string name, int totalWeight, int carbohydrates, int sugarAmount, int productHumiditly)
            : base(name, totalWeight, carbohydrates, sugarAmount)
        {

            ProductHumiditly = productHumiditly;

        }
                
        public override void DetermineSugar()
        {

            SugarWeight = TotalWeight * Сarbohydrates * SugarAmount * (150 - ProductHumiditly) / 1000000;

        }

    }
        
    
}
