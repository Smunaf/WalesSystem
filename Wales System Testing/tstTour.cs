using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalesClasses;
using System.Collections.Generic;

namespace Wales_System_Testing
{
    [TestClass]
    public class tstTour
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //test to see that it exists
            Assert.IsNotNull(ATour);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ATour.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.Active, TestData);
        }



    }
}
