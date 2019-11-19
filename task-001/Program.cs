using System;
using System.Collections.Generic;
using System.Text;
using task_001.Gifts;
using task_001.Sweets;


namespace task_001
{
    public class Program
    {
        static void Main()
        {

            List<Sweet> gift = new List<Sweet>();
            gift.Add(new Candies("Аленка", 95, 10));
            gift.Add(new Cakes("Медовик", 89, 15));
            gift.Add(new Candies("Леденец", 88, 18));
            gift.Add(new Cakes("Орео", 98, 56));


            foreach (Sweet sweet in gift)
                sweet.DetermineSugar();

            Console.ReadKey();



        }
  
    }

}
