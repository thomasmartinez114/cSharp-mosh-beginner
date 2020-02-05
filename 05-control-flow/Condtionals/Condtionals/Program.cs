using System;

namespace Condtionals
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
        }
    }
}
