using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;
using System;

namespace InvocationApp
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            var proxy = new ProxyGenerator();
            var aspect = proxy
                .CreateClassProxy<Employee>(
                    new DefensiveProgrammingAspect(),
                    new InterceptionAspect()
                );

            var emp1 = new Employee
            {
                Id = 1,
                FirstName = "Ahmet",
                LastName = "Can"
            };

            aspect.Add(emp1.Id,emp1.FirstName,emp1.LastName);

            Console.ReadKey();
        }
    }
}
