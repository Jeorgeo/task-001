using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Sweets
{
    public abstract class Sweet
    {

        // Name sweets

        public string Name { get; set; }

        // Full weight sweets (g)

        public int TotalWeight { get; set; }

        // Amount Carbohydrate per 100 g of sweet

        public int Сarbohydrates { get; set; }

        // Amount of sugar in the sweet (%)
        
        public int SugarAmount { get; set; }

        // Sugar weight in the sweet  (гр) 

        public int SugarWeight { get; protected set; } 

        public Sweet(string name, int totalWeight, int carbohydrates, int sugarAmount)
        {
            Name = name;

            SugarAmount = sugarAmount;

            TotalWeight = totalWeight;

            Сarbohydrates = carbohydrates;
        }

        // Calculate Sugar weight in the sweet

        public abstract void DetermineSugar(); 
    }
}
