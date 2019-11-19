using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using task_001.Sweets;

namespace task_001.Gifts
{
    public class Gift : IEnumerable<Candy>
    {
        private List<Candy> candies = new List<Candy>();

        public uint Weight { get; private set; }

        public void Add(Candy candy)
        {
            if (candy == null)
            {
                throw new ArgumentNullException(nameof(candy));
            }

            candies.Add(candy);
            Weight += candy.TotalWeight;
        }

  /*      public List<Candy> FindBy(uint minSugarWeight, uint maxSugarWeight)
        {
            return candies.Where(candy => candy.SugarWeight >= minSugarWeight && candy.SugarWeight <= maxSugarWeight).ToList();
        }

        public void OrderBy<TResult>(Func<Candy, TResult> comparer)
        {
            candies = candies.OrderBy(comparer).ToList();
        }

        public void OrderByDesceding<TResult>(Func<Candy, TResult> comparer)
        {
            candies = candies.OrderByDescending(comparer).ToList();
        }
*/
        public IEnumerator<Candy> GetEnumerator()
        {
            return candies.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
