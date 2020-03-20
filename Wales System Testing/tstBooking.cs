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
            ABooking.BookingNo = TestData;
            //test to see if the values are the same
            Assert.AreEqual(ABooking.BookingNo, TestData);
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
            ABooking.TourNo = TestData;
            //test to see if the values are the same
            Assert.AreEqual(ABooking.TourNo, TestData);
        }

        [TestMethod]
        public void DateandTime()
        {
            //create an instance of booking class
            clsBookings ABooking = new clsBookings();
            //create some test data and assign it to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ABooking.DateandTime = TestData;
            //test to see if the values are the same
            Assert.AreEqual(ABooking.DateandTime, TestData);
        }

        [TestMethod]
        public void PassengerCount()
        {
            //instance of vooking class
            clsBookings ABooking = new clsBookings();
            //test data assigned to the property
            Int32 TestData = 1;
            //assign the data to the property
            ABooking.PassengerCount = TestData;
            //test tp see if the values are the same
            Assert.AreEqual(ABooking.PassengerCount, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of booking class
            clsBookings ABooking = new clsBookings();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some tsest data to use with the method
            Int32 BookingNo = 1;
            //invoke the method
            Found = ABooking.Find(BookingNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestBookingNoFound()
        {
            //instance of booking class
            clsBookings ABooking = new clsBookings();
            //boolean variable to store the search result
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //test data to use with teh method
            Int32 BookingNo = 21;
            //invoke the method
            Found = ABooking.Find(BookingNo);
            //check the bookingno
            if (ABooking.BookingNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct]
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //instance of booking class
            clsBookings ABooking = new clsBookings();
            //boolean variable to store the result to the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingNo = 21;
            //invoke the method
            Found = ABooking.Find(BookingNo);
            //check the property
            if (ABooking.CustomerNo != 21)
            {
                OK = false;
            }
            //test the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTourNoFound()
        {
            //instance of booking class
            clsBookings ABooking = new clsBookings();
            //boolean variable to store the result to the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //est data to use with the method
            Int32 BookingNo = 21;
            //invoke the method
            Found = ABooking.Find(BookingNo);
            //check the property
            if (ABooking.TourNo != 21)
            {
                OK = false;
            }
            //test the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateandTimeFound()
        {
            //instance of booking class
            clsBookings ABooking = new clsBookings();
            //boolean variable to store the result to the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //test data to use with the method
            Int32 BookingNo = 21;
            //invoke the method
            Found = ABooking.Find(BookingNo);
            //check the property
            if (ABooking.DateandTime != Convert.ToDateTime("01/01/2010"))
            {
                OK = false;
            }
            //test the result
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPassengerCountFound()
        {
            //instance of booking class
            clsBookings ABooking = new clsBookings();
            //boolean variable to store the result to the search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with the method
            Int32 BookingNo = 21;
            //invoke the method
            Found = ABooking.Find(BookingNo);
            //check the property
            if (ABooking.PassengerCount != 21)
            {
                OK = false;
            }
            //test the result
            Assert.IsTrue(OK);
        }
    }
}
