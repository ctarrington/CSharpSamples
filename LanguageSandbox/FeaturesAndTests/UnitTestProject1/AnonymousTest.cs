using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class AnonymousTest
    {
        [TestMethod]
        public void TestAnonymousType()
        {
            Person fred = new Person("Fred", "Flintstone");

            var bob = new { Name = "Bob", Job = new { Role = "Butler" }, Friend = fred };
            Assert.AreEqual("Bob", bob.Name);
            Assert.AreEqual("Butler", bob.Job.Role);
            Assert.AreEqual("Flintstone", bob.Friend.LastName);

            bob.Friend.addNicknames("Freddy", "Fred the Rockman");

            Assert.AreEqual(2, bob.Friend.Nicknames.Count);
            Assert.IsTrue(fred.Nicknames.Contains("Freddy"));

        }
    }
}
