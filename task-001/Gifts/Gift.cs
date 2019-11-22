using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task_001.Sweets;

namespace task_001.Gifts
{

    public class Gift : IEnumerable<Sweet>
    {
        private List<Sweet> candies = new List<Sweet>();

        public int GiftWeight { get; private set; }

        public void Add(Sweet candy)
        {
            if (candy == null)
            {
                throw new ArgumentNullException(nameof(candy));
            }

            candies.Add(candy);
            GiftWeight += candy.TotalWeight;
        }

        public List<Sweet> FindBy(int minSugarWeight, int maxSugarWeight)
        {
            return candies.Where(candy => candy.SugarWeight >= minSugarWeight && candy.SugarWeight <= maxSugarWeight).ToList();
        }

        public void OrderBy<TResult>(Func<Sweet, TResult> comparer)
        {
            candies = candies.OrderBy(comparer).ToList();
        }

        public void OrderByDesceding<TResult>(Func<Sweet, TResult> comparer)
        {
            candies = candies.OrderByDescending(comparer).ToList();
        }

        public IEnumerator<Sweet> GetEnumerator()
        {
            return candies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
