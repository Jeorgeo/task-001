using System;
using System.Collections.Generic;
using task_001.Gifts;
using task_001.Sweets;


namespace task_001
{
    public class Program
    {
        static void Main()
        {

            Gift big = new Gift();

            List<Sweet> gift = new List<Sweet>
            {
                 new Candies("Аленка", 10, 85, 90),
                 new Cakes("Медовик", 30, 70, 79, 60),
                 new Candies("Леденец", 8, 90, 95),
                 new Cakes("Орео", 28, 80, 86, 80)
            };

            for (int i = 0; i < gift.Count; i++)
            {
                 Sweet sweet1 = gift[i];
                 big.Add(sweet1);
                 sweet1.DetermineSugar();
                 Console.WriteLine($"Имя: {sweet1.Name} Вес: {sweet1.TotalWeight} гр/-сахара {sweet1.SugarWeight} гр/" );
            }

            Console.WriteLine($"Вес подарка {big.GiftWeight} гр");

            var foundSweet  = big.FindBy(12, 14);

            for (int i = 0; i < foundSweet.Count; i++)
            {
                Console.WriteLine(foundSweet[i].Name);
            }

            big.OrderBy(x => x.SugarWeight);

            foreach (var item in big)
            {
                Console.WriteLine(item.SugarWeight);
            }

            

            Console.ReadKey();
                       
        }
  
    }

}
