using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalesClasses;

namespace Wales_System_Testing
{
    [TestClass]
    public class tstBooking
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of booking class
            clsBookings ABooking = new clsBookings();
            //test to see that it exists
            Assert.IsNotNull(ABooking);
        }

        [TestMethod]
        public void BookingNoPropertyOK()
        {
            //create an instance of booking class
            clsBookings ABooking = new clsBookings();
            //create some test data and assign it to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.TourNo = TestData;
            //test to see if the values are the same
            Assert.AreEqual(ABooking.TourNo, TestData);
        }

        [TestMethod]
        public void CustomerPropertyOK()
        {
            //create an instance of booking class
            clsBookings ABooking = new clsBookings();
            //create some test data and assign it to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.CustomerNo = TestData;
            //test to see if the values are the same
            Assert.AreEqual(ABooking.CustomerNo, TestData);
        }

        [TestMethod]
        public void TourNoPropertyOK()
        {
            //create an instance of booking class
            clsBookings ABooking = new clsBookings();
            //create some test data and assign it to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.BookingNo = TestData;
            //test to see if the values are the same
            Assert.AreEqual(ABooking.BookingNo, TestData);
        }
    }
}
