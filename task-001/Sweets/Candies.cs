using System;
using System.Collections.Generic;
using System.Text;
using task_001.Sweets;

namespace task_001.Sweets
{
    public class Candies : Sweet
    {
        public Candies(string name, int sugarAmount, int weight)
        {
            Name = name;

            SugarAmount = sugarAmount;

            Weight = weight;

        }

        enum CandiesType { Alenka, Ledenec, BubleGum };

        public override void DetermineSugar()
        {
            var c = SugarAmount * Weight * 0.9 / 100;
            Console.WriteLine(c);
        }

    }
}
