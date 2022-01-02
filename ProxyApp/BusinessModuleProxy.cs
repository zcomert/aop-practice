using System;

namespace ProxyApp
{
    public class BusinessModuleProxy : IBusinessModule
    {
        private BusinessModule _realObject;
        public BusinessModuleProxy()
        {
            _realObject = new BusinessModule();
        }
        public void Method()
        {
            Console.WriteLine("Before method.");
            _realObject.Method();
            Console.WriteLine("After method.");
        }
    }
}
