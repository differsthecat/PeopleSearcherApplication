using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PeopleSearcher.Models
{
    public class PeopleSearcherContext : DbContext, IPeopleSearcherContext
    {
        public PeopleSearcherContext() : base("name=PeopleSearcherContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PeopleSearcherContext, Migrations.Configuration>());
        }

        public System.Data.Entity.DbSet<PeopleSearcher.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<PeopleSearcher.Models.Interest> Interests { get; set; }


        public void MarkAsModified(Person p)
        {
            Entry(p).State = EntityState.Modified;
        }

        public void MarkAsModified(Interest i)
        {
            Entry(i).State = EntityState.Modified;
        }
    }
}
