using Autofac;

namespace Module3HW1
{
    public class DIConfig
    {
        public IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MyList<int>>().As<IMyList<int>>();
            builder.RegisterType<Starter>();

            var container = builder.Build();

            return container;
        }
    }
}
