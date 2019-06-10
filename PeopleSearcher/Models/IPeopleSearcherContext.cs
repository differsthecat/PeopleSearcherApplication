using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSearcher.Models
{
    public interface IPeopleSearcherContext
    {
        DbSet<Person> People { get; }
        DbSet<Interest> Interests { get; }
        int SaveChanges();
        void MarkAsModified(Person p);
    }
}
