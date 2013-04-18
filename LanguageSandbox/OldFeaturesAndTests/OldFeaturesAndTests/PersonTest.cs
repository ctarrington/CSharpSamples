using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OldFeaturesAndTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person joe = new Person("Joe", "Smith");
            Assert.AreEqual("Joe", joe.FirstName);
            Assert.AreEqual("Smith", joe.LastName);

            Person backwards = new Person(lastName: "htimS", firstName: "eoJ");
            Assert.AreEqual("eoJ", backwards.FirstName);
            Assert.AreEqual("htimS", backwards.LastName);

            Person nobody = new Person();
            Assert.AreEqual("John", nobody.FirstName);
            Assert.AreEqual("Doe", nobody.LastName);

            Person nfn = new Person(lastName: "Smith");
            Assert.AreEqual("John", nfn.FirstName);
            Assert.AreEqual("Smith", nfn.LastName);
        }
    }
}
