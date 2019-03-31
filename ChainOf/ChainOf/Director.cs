namespace ChainOf
{
    using System;

    //La clase ManejadorConcreto1
    public class Director : IApprover
    {
        public void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, purchase.Number);
            }
        }
    }
}
