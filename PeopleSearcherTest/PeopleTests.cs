using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearcher.Controllers;
using PeopleSearcher.Models;
using PeopleSearcher.Tests;

namespace PeopleSearcherTest
{
    [TestClass]
    public class PeopleTests
    {
        [TestMethod]
        public void GetPeople_EmptyFilter()
        {
            var context = new TestPeopleSearcherContext();

            var demoPeople = GetDemoPeople();

            foreach (var d in demoPeople)
            {
               context.People.Add(d);
            }

            var controller = new PeopleController(context);
            var result = controller.GetPeople(null);

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetPeople_WithFilter()
        {
            var context = new TestPeopleSearcherContext();

            var demoPeople = GetDemoPeople();
            foreach (var d in demoPeople)
            {
                context.People.Add(d);
            }

            var controller = new PeopleController(context);
            var result = controller.GetPeople("j");

            Assert.IsNotNull(result); 
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void GetPeople_WithLongFilter()
        {
            var context = new TestPeopleSearcherContext();

            var demoPeople = GetDemoPeople();
            foreach (var d in demoPeople)
            {
                context.People.Add(d);
            }

            var controller = new PeopleController(context);
            var result = controller.GetPeople("jhklmn");

            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        // Test Data
        private List<Person> GetDemoPeople()
        {
            var testPeople = new List<Person>();
            testPeople.Add(new Person
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe",
                Address = "123 Test Street",
                Age = 35,
                Interests = new List<Interest>
                {
                    new Interest { Id = 1, PersonId = 1, Title = "Hiking"},
                    new Interest { Id = 2, PersonId = 1, Title = "Snow Boarding"}
                }
            });
            testPeople.Add(new Person
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                Address = "123 Test Ave",
                Age = 40
            });
            testPeople.Add(new Person
            {
                Id = 1,
                FirstName = "Ralph",
                LastName = "Anderson",
                Address = "3456 Assert Road",
                Age = 35
            });

            return testPeople;
        }
    }
}
