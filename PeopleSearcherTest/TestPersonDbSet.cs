using System;
using System.Linq;
using PeopleSearcher.Models;
using PeopleSearcher.Tests;

namespace PeopleSearcher.Tests
{
    class TestPersonDbSet : TestDbSet<Person>
    {
        public override Person Find(params object[] keyValues)
        {
            return this.SingleOrDefault(p => p.Id == (int)keyValues.Single());
        }
    }
}