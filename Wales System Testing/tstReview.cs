﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalesClasses;

namespace Wales_System_Testing
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsReview AnReview = new clsReview();
            //test to see that it exists
            Assert.IsNotNull(AnReview);
        }
    }
}
