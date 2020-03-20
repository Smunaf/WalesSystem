using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WalesClasses;
namespace Wales_System_Testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomer);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            //Set its properties
            TestItem.CustomerNo = 1;
            TestItem.Address = "Cloutsham";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.FirstName = "Drake";
            TestItem.SureName = "Maverick";
            TestItem.Email = "drake.13@hotmail.com";
            TestItem.Telephone = 1;
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //Set its properties
            TestCustomer.CustomerNo = 1;
            TestCustomer.Address = "Cloutsham";
            TestCustomer.DOB = DateTime.Now.Date;
            TestCustomer.FirstName = "Drake";
            TestCustomer.SureName = "Maverick";
            TestCustomer.Email = "drake.13@hotmail.com";
            TestCustomer.Telephone = 1;
            //assign the data to the property
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //var
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CustomerNo = 1;
            TestItem.Address = "Cloutsham";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.FirstName = "Drake";
            TestItem.SureName = "Maverick";
            TestItem.Email = "drake.13@hotmail.com";
            TestItem.Telephone = 1;
            //assign the data to the property
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //var
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.CustomerNo = 1;
            TestItem.Address = "Cloutsham";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.FirstName = "Drake";
            TestItem.SureName = "Maverick";
            TestItem.Email = "drake.13@hotmail.com";
            TestItem.Telephone = 1;
            //assign the data to the property
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //delete the record
            AllCustomer.Delete();
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);





        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestItem = new clsCustomer();
            //var
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.Address = "Cloutsham";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.FirstName = "Drake";
            TestItem.SureName = "Maverick";
            TestItem.Email = "drake.13@hotmail.com";
            TestItem.Telephone = 1;
            //assign the data to the property
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the primary key of the test data
            TestItem.CustomerNo = PrimaryKey;
            //delete the record
            TestItem.Address = "Lillard Street";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.FirstName = "Cole";
            TestItem.SureName = "Daverick";
            TestItem.Email = "James.16@hotmail.co.uk";
            TestItem.Telephone = 2;
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }
        [TestMethod]
        public void ReportByPostCodeMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create an instance of the filtered data
            clsCustomerCollection filteredCustomer = new clsCustomerCollection();
            //apply a blank blank string (should return all records
            filteredCustomer.ReportByAddress("");
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, filteredCustomer.Count);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerNo = 1;
            Found = AnCustomer.Find(CustomerNo);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 2;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the customer no
            if (AnCustomer.CustomerNo != 2)
            {
                OK = false;
            }
        }

    }
}


