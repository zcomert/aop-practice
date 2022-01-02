using Castle.DynamicProxy;
using System;

namespace CastleDynamicProxyFirstApp
{
    public class MyInterceptorAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before {0}",invocation.Method);
            invocation.Proceed();
            Console.WriteLine("After {0}",invocation.Method);
        }
    }
    public class MyClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod body.");
        }
    }

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
