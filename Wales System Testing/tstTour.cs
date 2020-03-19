using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using WalesClasses;
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
        public void TourNoOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            ATour.TourNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.TourNo, TestData);
        }

        [TestMethod]
        public void TourNameOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            string TestData = "WalesHeli";
            //assign the data to the property
            ATour.TourName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.TourName, TestData);
        }

        [TestMethod]
        public void LocationOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            string TestData = "Wales";
            //assign the data to the property
            ATour.Location = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.Location, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ATour.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.Date, TestData);
        }

        [TestMethod]
        public void DepartureTimeOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ATour.DepartureTime = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.DepartureTime, TestData);
        }

        [TestMethod]
        public void CapacityOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            ATour.Capacity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.Capacity, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            decimal TestData = 4999;
            //assign the data to the property
            ATour.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.Price, TestData);
        }

        [TestMethod]
        public void AircraftModelOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            string TestData = "Wales";
            //assign the data to the property
            ATour.AircraftModel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.AircraftModel, TestData);
        }

        [TestMethod]
        public void TourGuideOK()
        {
            //create an instance of the class we want to create
            clsTour ATour = new clsTour();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ATour.TourGuide = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ATour.TourGuide, TestData);
        }



    }
}
