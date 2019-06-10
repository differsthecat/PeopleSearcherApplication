using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PeopleSearcher.Models
{
    public class Interest
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        // Foreign Key for Person
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}