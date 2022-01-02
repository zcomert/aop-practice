using Autofac;
using Castle.DynamicProxy;
using Entities;
using System;

namespace InvocationApp
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Can"
            };


            var builder = new ContainerBuilder();
            builder.RegisterModule(new DefaultModule());

            var container = builder.Build();
            var willBeIntercepted = container.Resolve<IEmployee>();
            willBeIntercepted.Add(emp1.Id, emp1.FirstName, emp1.LastName);
          
            Console.ReadKey();
        }
    }
}
