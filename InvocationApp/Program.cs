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
                .CreateClassProxy<Employee>(new InterceptionAspect());

            aspect.Add(1, "Zafer", "Cömert");

            Console.ReadKey();
        }
    }
}
