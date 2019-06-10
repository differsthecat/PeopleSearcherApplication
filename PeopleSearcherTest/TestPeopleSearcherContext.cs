using System;
using System.Data.Entity;
using PeopleSearcher.Models;

namespace PeopleSearcher.Tests
{
    public class TestPeopleSearcherContext : IPeopleSearcherContext
    {
        public TestPeopleSearcherContext()
        {
            this.People = new TestPersonDbSet();
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Interest> Interests { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(Person p) { }
        public void Dispose() { }
    }
}