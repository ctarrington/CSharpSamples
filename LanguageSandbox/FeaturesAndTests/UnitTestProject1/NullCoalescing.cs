using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class NullCoalescing
    {
        [TestMethod]
        public void TestMethod1()
        {
            string userSpecified = null;
            string configSpecified = null;
            string defaultValue = "hi";

            // find the first non-null value
            Assert.AreEqual("hi", (userSpecified ?? configSpecified ?? defaultValue));
           
            configSpecified = "config says hi";
            Assert.AreEqual("config says hi", (userSpecified ?? configSpecified ?? defaultValue));

            userSpecified = "user says hi";
            Assert.AreEqual("user says hi", (userSpecified ?? configSpecified ?? defaultValue));
        }
    }
}
