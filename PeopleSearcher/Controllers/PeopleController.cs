using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using PeopleSearcher.Models;

namespace PeopleSearcher.Controllers
{
    public class PeopleController : ApiController
    {
        private IPeopleSearcherContext db = new PeopleSearcherContext();

        public PeopleController() { }

        public PeopleController(IPeopleSearcherContext context)
        {
            db = context;
        }

        // GET: api/People/{filter}
        public List<Person> GetPeople(string filter)
        {
            if (filter == null)
            {
                return new List<Person>();
            }
            else
            {
                return db.People
                    .Include(i => i.Interests)
                    .Where(a =>
                        a.FirstName.ToUpper().Contains(filter.ToUpper()) ||
                        a.LastName.ToUpper().Contains(filter.ToUpper()))
                    .ToList();
            }
        }

        // GET: api/People/{id}
        [ResponseType(typeof(Person))]
        public async Task<IHttpActionResult> GetPerson(int id)
        {
            Person person = await db.People.Include("Interests").SingleOrDefaultAsync(i => i.Id == id);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        private bool PersonExists(int id)
        {
            return db.People.Count(e => e.Id == id) > 0;
        }
    }
}