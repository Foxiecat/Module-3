using System.Data.Common;
using NUnit.Framework;
using ObligEn;

namespace ObligEnTests
{
    public class PersonTest
    {
        [Test]
        public void TestAllFields()
        {
            
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";
            
            Assert.AreEqual(expectedDescription, actualDescription);
        }
        
        [Test]
        public void TestNoFields()
        {
            var pp = new Person
            {
                Id = 1,
            };

            var actualDescription = pp.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestSomeFields()
        {
            var ppp = new Person
            {
                Id = 2,
                FirstName = "Danica Ellefsen",
                LastName = "Kvilhaug",
                BirthYear = 1997
            };

            var actualDescription = ppp.GetDescription();
            var expectedDescription = "Danica Ellefsen Kvilhaug (Id=2) Født: 1997 ";
            
            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}