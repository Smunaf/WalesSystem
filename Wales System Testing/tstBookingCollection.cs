using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalesClasses;

namespace Wales_System_Testing
{
    [TestClass]
    public class tstBookingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create and instance of the booking collection class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test to see that it exists
            Assert.IsNotNull(AllBookings);
        }
    }
}
