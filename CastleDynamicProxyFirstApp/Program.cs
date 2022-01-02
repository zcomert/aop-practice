using Castle.DynamicProxy;
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
            Console.ReadLine();
        }
    }
}
