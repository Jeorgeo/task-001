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
                 Sweet sweet = gift[i];
                 big.Add(sweet);
                 sweet.DetermineSugar();
                 Console.WriteLine($"Имя: {sweet.Name} Вес: {sweet.TotalWeight} гр/-сахара {sweet.SugarWeight} гр/" );
            }

            Console.WriteLine($"Вес подарка {big.GiftWeight} гр");

            var foundSweet  = big.FindBy(12, 14);

            for (int i = 0; i < foundSweet.Count; i++)
            {
                Console.WriteLine(foundSweet[i].Name);
            }

            Console.ReadKey();
                       
        }
  
    }

}
