using System;

namespace CastleDynamicProxyFirstApp
{
    public interface IMyClass
    {
        void MyMethod();
    }
    
    public class MyClass : IMyClass
    {
        [MyInterceptorAspect(Priority = 1)]
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMethod body.");
        }
    }
}
