namespace ChainOf
{
    using System;

    public class MainApp
    {
        public static void Main()
        {
            var manager = DIContainer.Resolve<IApproverManager>();

            var p = new Purchase(2034, 350.00, "Assets");

            manager.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");

            manager.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");

            manager.ProcessRequest(p);

            Console.ReadKey();
        }
    }
}
