using System;
using System.Collections.Generic;
using System.Text;

namespace task_001.Gifts
{
    abstract class Gift
    {
        public string NameGift { get; private set; }

        public int WeightGift { get; private set; }

        protected abstract void SortSweets();

        protected abstract void AddSweets();

        protected abstract void RemoveSweets();
    }
}
