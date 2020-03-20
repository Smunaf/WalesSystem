using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalesClasses;

namespace Test_Framework
{
    [TestClass]
    public class tstUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //test to see that it exists
            Assert.IsNotNull(AUser);
        }

        [TestMethod]
        public void UserIDOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.UserID, TestData);
        }

        [TestMethod]
        public void FirstNameOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Thomas";
            //assign the data to the property
            AUser.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.FirstName, TestData);
        }


        [TestMethod]
        public void SecondNameOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Harvey";
            //assign the data to the property
            AUser.SecondName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.SecondName, TestData);
        }

        [TestMethod]
        public void RoleOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "Admin";
            //assign the data to the property
            AUser.Role = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Role, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "89 Upperton";
            //assign the data to the property
            AUser.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Address, TestData);
        }

        [TestMethod]
        public void DOBOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AUser.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.DOB, TestData);
        }


        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            string TestData = "thomas@gmail.com";
            //assign the data to the property
            AUser.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.Email, TestData);
        }

        [TestMethod]
        public void TelephoneNumberOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            int TestData = 27634528;
            //assign the data to the property
            AUser.TelephoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.TelephoneNumber, TestData);
        }

        [TestMethod]
        public void AdminPrivilegesOK()
        {
            //create an instance of the class we want to create
            clsUser AUser = new clsUser();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AUser.AdminPrivileges = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AUser.AdminPrivileges, TestData);
        }



    }
}



