using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int TotalIncome { get; set; }

        public void Sell()
        {
            if (Count == 0)
            {
                return;
            }
            Count = Count - 1;
            TotalIncome = TotalIncome + Price;
        }

    }
}
