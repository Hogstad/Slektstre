using NUnit.Framework;
using Slektstre;

namespace SlektstreTest
{
    class PersonTest
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
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void Flemming()
        {
            var p = new Person
            {
                Id = 13,
                FirstName = "Flemming",
                LastName = "Hogstad",
                BirthYear = 1989,
                Father = new Person() { Id = 55, },
                Mother = new Person() { Id = 44, },
            };

            var actualDescriptio = p.GetDescription();
            var expectedDescriptio = "Flemming Hogstad (Id=13) Født: 1989 Far: (Id=55) Mor: (Id=44)";

            Assert.AreEqual(actualDescriptio, expectedDescriptio);
        }
    }
}
