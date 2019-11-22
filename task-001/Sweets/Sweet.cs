using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Sweets
{
    public abstract class Sweet
    {

        public string Name { get; set; } // Название сладости

        public int TotalWeight { get; set; } // Полный вес сладости (гр)

        public int Сarbohydrates { get; set; } // Содержание углеводов в 100 гр продукта (гр)

        public int SugarAmount { get; set; } // Содержание сахара в сладости (%)

        public int SugarWeight { get; protected set; } // Вес сахара в сладости (гр) 

        public Sweet(string name, int totalWeight, int carbohydrates, int sugarAmount)
        {
            Name = name;

            SugarAmount = sugarAmount;

            TotalWeight = totalWeight;

            Сarbohydrates = carbohydrates;
        }

        public abstract void DetermineSugar(); // Вычисление веса сахара в сладости
    }
}
