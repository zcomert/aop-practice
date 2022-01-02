using Castle.DynamicProxy;
using Core.Interceptors;
using System;

namespace CastleDynamicProxyFirstApp
{
    public class MyInterceptorAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Before {0}", invocation.Method);
        }

        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine("After {0}", invocation.Method);
        }
    }
}
