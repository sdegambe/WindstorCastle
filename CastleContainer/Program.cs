using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Lifestyle;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace CastleContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic();
            FromMethod();
            FromProperties();
            //ObjectType();
            Console.ReadLine();
        }

        private static void Basic()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<Service>());
            container.Register(Component.For<IWriter>().ImplementedBy<FileWriter>());
            container.Register(Component.For<IReader>().ImplementedBy<DBReader>());
            var service = container.Resolve<Service>();
            service.Read();
            service.Write();
        }

        private static void FromMethod()
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<Service2>());
            container.Register(Component.For<IWriter>().ImplementedBy<FileWriter>());
            container.Register(Component.For<IReader>().ImplementedBy<FileReader>());
            var service = container.Resolve<Service2>();
            service.Read(container.Resolve<IReader>());
            service.Write(container.Resolve<IWriter>());
            service.TryRead();
            service.TryWrite();
        }

        private static void FromProperties()
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<Service3>());
            container.Register(Component.For<IWriter>().ImplementedBy<FileWriter>());
            container.Register(Component.For<IReader>().ImplementedBy<FileReader>());
            var service = container.Resolve<Service3>();
            service.Read();
            service.Write();

        }

        private static void ObjectType()
        {
            WindsorContainer container = new WindsorContainer();
            container.Register(Component.For<Service4>().LifeStyle.Transient*/);
            container.Register(Component.For<IReader>().ImplementedBy<FileReader>()/*.LifeStyle.Transient*/);
            var service = container.Resolve<Service4>();
            service.Read();
            var service2 = container.Resolve<Service4>();
            service2.Read();
        }

    }
}
