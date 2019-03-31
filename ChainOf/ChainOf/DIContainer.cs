namespace ChainOf
{
    using Autofac;

    public static class DIContainer
    {
        private static IContainer container;

        static DIContainer()
        {
            container = CreateContainer();
        }

        public static T Resolve<T>()
        {
            return container.Resolve<T>();
        }

        private static IContainer CreateContainer()
        {
            var contBuilder = new ContainerBuilder();
            contBuilder.RegisterType<ApproverManager>().As<IApproverManager>().InstancePerDependency();
            contBuilder.RegisterType<Director>().As<IApprover>().InstancePerDependency();
            contBuilder.RegisterType<President>().As<IApprover>().InstancePerDependency();
            contBuilder.RegisterType<VicePresident>().As<IApprover>().InstancePerDependency();
            return contBuilder.Build();
        }
    }
}
