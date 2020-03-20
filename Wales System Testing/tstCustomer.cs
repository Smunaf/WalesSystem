using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalesClasses;

namespace Wales_System_Testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            //test to se that it exists
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we wamt to create
            clsCustomer AnAddress = new clsCustomer();
            //create some test datat to assign to the property
            string TestData = "Cloutsham Street";
            //assign the data to the property
            AnAddress.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Address, TestData);
        }
        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we wamt to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test datat to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);

        }
        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class we wamt to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test datat to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnCustomer.DOB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we wamt to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test datat to assign to the property
            string TestData = "MLK12@hotmail.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we wamt to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test datat to assign to the property
            string TestData = "Mahdi";
            //assign the data to the property
            AnCustomer.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }
        [TestMethod]
        public void SureNamePropertyOK()
        {
            //create an instance of the class we wamt to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test datat to assign to the property
            string TestData = "Ali";
            //assign the data to the property
            AnCustomer.SureName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.SureName, TestData);
        }
        [TestMethod]
        public void TelephonePropertyOK()
        {
            //create an instance of the class we wamt to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test datat to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnCustomer.Telephone = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Telephone, TestData);
        }
        
       
    }
}
