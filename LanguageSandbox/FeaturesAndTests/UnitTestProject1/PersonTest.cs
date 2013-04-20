using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestName()
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

            // nfn.FirstName = "Ted";  compiler error because setters are private
        }

        [TestMethod]
        public void TestLists()
        {
            List<Person> people = new List<Person> { new Person(), new Person("Ted", "TheDog"), new Person("Fred", "TheDog"), new Person("Joe", "Schmoo") };
            Assert.AreEqual("Joe", people[3].FirstName);
            Assert.AreEqual("Schmoo", people[3].LastName);
            Assert.AreEqual(4, people.Count);

            List<Person> theJoes = people.FindAll(p => p.FirstName.Equals("Joe"));
            Assert.AreEqual(1, theJoes.Count);

            theJoes.Add(new Person("Joe", "Soe"));
            Assert.AreEqual(2, theJoes.Count);
            Assert.AreEqual(4, people.Count);

            var joeschmoo = theJoes.FindAll(p => p.FirstName.Equals("Joe") && p.LastName.Equals("Schmoo"));
            Assert.AreEqual(1, joeschmoo.Count);

            var sando = theJoes.FindAll(p => p.FirstName.Equals("Joe") && Regex.IsMatch(p.LastName, "S.*o.*"));
            Assert.AreEqual(2, sando.Count);

            StringBuilder sb = new StringBuilder();
            foreach (Person person in people)
            {
                sb.Append(String.Format("{0}, {1}\n", person.LastName, person.FirstName));
            }

            string pretty = sb.ToString();
            Assert.AreEqual("Doe, John\nTheDog, Ted\nTheDog, Fred\nSchmoo, Joe\n", pretty);
        }

    }
}
