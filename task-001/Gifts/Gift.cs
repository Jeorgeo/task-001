using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Gifts
{
    abstract class Gift
    {
        public string NameGift { get; set; }

        public int WeightGift { get; set; }

        public abstract void SortSweets();

        public abstract void AddSweets();

        public abstract void RemoveSweets();
    }
}
