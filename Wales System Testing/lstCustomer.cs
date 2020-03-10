using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Wales_System_Testing
{
    [TestClass]
    public class lstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //test to se that it exists
            Assert.IsNotNull(AnCustomer);
        }
    }
}
