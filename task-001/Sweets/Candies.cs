using System;
using System.Collections.Generic;
using System.Text;
using task_001.Sweets;

namespace task_001.Sweets
{
    public class Candies
    {
        public string Name
        {
            get { return Name; }

            private set { Name = value; }
        }

        public double СarbohydratesAmount
        {
            get { return СarbohydratesAmount; }

            private set { СarbohydratesAmount = value; }
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

        enum CandyType {Sweetmeat, Chocolate, Marmalade};

        public void DetermineSugarAmount(int СarbohydratesAmount, int SugarAmount)
        {

            CandyType x = CandyType.Chocolate;
            var k = 0.1;

            switch (x) {
                case CandyType.Sweetmeat:
                    k = 0.5;
                    break;
                case CandyType.Chocolate:
                    k = 0.7;
                    break;
                case CandyType.Marmalade:
                    k = 0.9;
                    break;
            }

            var c = СarbohydratesAmount * SugarAmount * k;

            Console.WriteLine(c);

            Console.ReadKey();

        }

    }
}
