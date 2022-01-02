using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;
using System;

namespace CastleDynamicProxyFirstApp
{

    public class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy
                .CreateClassProxy<MyClass>(new MyInterceptorAspect());
            aspect.MyMethod();

            Console.WriteLine(new String('-',50));

            var builder = new ContainerBuilder();
            builder.RegisterType<MyClass>()
                .As<IMyClass>()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions() { 
                    Selector = new AspectInterceptorSelector()
                })
                .InstancePerDependency();

            var container = builder.Build();
            var willBeIntercepted = container.Resolve<IMyClass>();
            willBeIntercepted.MyMethod();

            Console.ReadLine();
        }
    }
}
