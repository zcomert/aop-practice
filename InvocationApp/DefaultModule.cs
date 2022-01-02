using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var proxyOptions = new ProxyGenerationOptions
            {
                Selector = new AspectInterceptorSelector()
            };

            builder.RegisterType<Employee>()
                .As<IEmployee>()
                .EnableInterfaceInterceptors(proxyOptions)
                .SingleInstance();

        }
    }
}
