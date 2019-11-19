using System;
using System.Collections.Generic;
using System.Text;
using task_001.Sweets;

namespace task_001.Sweets
{
    public class Candies : Sweets
    {
        public string Name { get; set; }

        public Candies(string name)
        {
            Name = name;
        }
                
        public double SugarAmount
        {
            get { return SugarAmount; }

            private set { SugarAmount = value; }
        }

        public int Weight
        {
            get { return Weight; }

            private set { Weight = value; }
        }

        public override void DetermineSugarAmount()
        {
            Console.WriteLine("Введите содержание сахара в %");
            SugarAmount = Convert.ToInt32(Console.ReadLine());
            if (SugarAmount > 100)
            {
                Console.WriteLine("Содержание сахара не может быть больше 100%, попробуйте еще раз");
                SugarAmount = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите вес конфеты в гр");
            Weight = Convert.ToInt32(Console.ReadLine()); 

            if (SugarAmount > 100)
            {
                Console.WriteLine("Содержание сахара не может быть больше 100%");
            }                      

            var Sugar = Weight * SugarAmount / 100;

            Console.WriteLine("В конфете" + Sugar + "гр сахара");

            Console.ReadKey();

        }

    }
}
