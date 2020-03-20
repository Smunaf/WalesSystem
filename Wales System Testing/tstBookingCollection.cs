using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalesClasses;
using System.Collections.Generic;

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

        [TestMethod]
        public void BookingListOK()
        {
            //create an instance of the collection class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test data to assign to the property--data needs to be in a list
            List<clsBookings> TestList = new List<clsBookings>();
            //add an item to the lst
            clsBookings TestItem = new clsBookings();
            //set its properties
            TestItem.BookingNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.TourNo = 1;
            TestItem.DateandTime = DateTime.Now.Date;
            TestItem.PassengerCount = 1;
            //add the item tothe test list
            TestList.Add(TestItem);
            //assign the data tothe property
            AllBookings.BookingList = TestList;
            //test to see tjat tje two are the same
            Assert.AreEqual(AllBookings.BookingList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //instance of collection class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test data to assign to the property
            Int32 SomeCount = 2;
            //assign the data to the property
            AllBookings.Count = SomeCount;
            //test to see that the two are the same
            Assert.AreEqual(AllBookings.Count, SomeCount);
        }

        [TestMethod]
        public void ThisBookingPropertyOK()
        {
            //instance of collection  class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test data t assign to the property
            clsBookings TestBooking = new clsBookings();
            //set the properties
            TestBooking.BookingNo = 1;
            TestBooking.CustomerNo = 1;
            TestBooking.TourNo = 1;
            TestBooking.DateandTime = DateTime.Now.Date;
            TestBooking.PassengerCount = 1;
            //assign the data to the property
            AllBookings.ThisBooking = TestBooking;
            //test to see that the two are the same
            Assert.AreEqual(AllBookings.ThisBooking, TestBooking);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //instance of collection class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test data to assign to the property
            List<clsBookings> TestList = new List<clsBookings>();
            //add an item to the list--create the item of test data
            clsBookings TestItem = new clsBookings();
            //set it properties
            TestItem.BookingNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.TourNo = 1;
            TestItem.DateandTime = DateTime.Now.Date;
            TestItem.PassengerCount = 1;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllBookings.BookingList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllBookings.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //instance of collection class
            clsBookingCollection AllBookings = new clsBookingCollection();
            //test data
            clsBookings TestItem = new clsBookings();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.BookingNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.TourNo = 1;
            TestItem.DateandTime = DateTime.Now.Date;
            TestItem.PassengerCount = 1;
            //set thisBooking to the test data
            AllBookings.ThisBooking = TestItem;
            //add recprd
            PrimaryKey = AllBookings.Add;
            //set the primary key of the test data
            TestItem.BookingNo = PrimaryKey;
            //find the record
            AllBookings.ThisBooking.Find(PrimaryKey);
            //test to see that th 
            //e two values are the same
            Assert.AreEqual(AllBookings.ThisBooking, TestItem);
        }
    }
}
