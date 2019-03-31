namespace ChainOf
{
    //La clase ManejadorConcreto2
    using System;

    public class VicePresident : IApprover
    {
        public void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",

                this.GetType().Name, purchase.Number);
            }
        }
    }
}