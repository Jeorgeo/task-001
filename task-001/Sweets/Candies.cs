using System;
using System.Collections.Generic;
using System.Text;
using task_001.Sweets;

namespace task_001.Sweets
{
    public class Candies : Sweet
    {
        
        public Candies(string name, int totalweight, int carbohydrates, int sugarAmount)
            : base(name, totalweight, carbohydrates, sugarAmount)
        {

        }
                                              
        public override void DetermineSugar()
        {

            SugarWeight = TotalWeight * Сarbohydrates * SugarAmount / 10000;

        }

    }
}
