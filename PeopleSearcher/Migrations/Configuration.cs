namespace PeopleSearcher.Migrations
{
    using PeopleSearcher.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Mvc;

    internal sealed class Configuration : DbMigrationsConfiguration<PeopleSearcher.Models.PeopleSearcherContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PeopleSearcher.Models.PeopleSearcherContext context)
        {
            context.People.AddOrUpdate(x => x.Id,
                new Person() { Id = 1, FirstName = "John", LastName = "Snow", Age = 23, Address = "700 Wall Lane", PicUrl= "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/John.jpg" },
                new Person() { Id = 2, FirstName = "Daenerys", LastName = "Targaryen" , Age = 23, Address = "1 Kings Landing Circle", PicUrl = "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/daenerys.jpg" },
                new Person() { Id = 3, FirstName = "Tyrion", LastName = "Lannister", Age = 39, Address = "313 Westerland Ave", PicUrl= "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/tyrion.png" },
                new Person() { Id = 4, FirstName = "Sansa", LastName = "Stark", Age = 20, Address = "1439 Winterfell Ave", PicUrl = "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/Sansa.png" },
                new Person() { Id = 5, FirstName = "Jorah", LastName = "Mormont", Age = 51, Address = "253 Bear Island", PicUrl = "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/Jorah.jpg" },
                new Person() { Id = 6, FirstName = "Arya", LastName = "Stark", Age = 18, Address = "1447 Winterfell Ave", PicUrl = "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/arya.jpg" },
                new Person() { Id = 7, FirstName = "Cersei", LastName = "Lannister", Age = 43, Address = "P.O. Box 283 8562 Casterly Rd", PicUrl = "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/Cersei.jpg" },
                new Person() { Id = 8, FirstName = "Tormund", LastName = "Giantsbane", Age = 37, Address = "67 North Wall Rd", PicUrl = "https://rmcute-people-searcher.s3.us-east-2.amazonaws.com/Tormund.jpg" },
                new Person() { Id = 9, FirstName = "Jaqen", LastName = "H'ghar", Age = null, Address = "323 White Hall Lane"  }
                );
            context.Interests.AddOrUpdate(x => x.Id,
                new Interest() { Id = 3, Title = "Swordsmanship", PersonId = 1 },
                new Interest() { Id = 4, Title = "Breaking Chains", PersonId = 2 },
                new Interest() { Id = 1, Title = "Drinking", PersonId = 3 },
                new Interest() { Id = 2, Title = "Knowing Things", PersonId = 3 },
                new Interest() { Id = 5, Title = "Embroidery", PersonId = 4 },
                new Interest() { Id = 6, Title = "Daenerys", PersonId = 5 },
                new Interest() { Id = 7, Title = "Archery", PersonId = 6 },
                new Interest() { Id = 8, Title = "Parties", PersonId = 7 },
                new Interest() { Id = 9, Title = "Milk", PersonId = 8 }
                );
            base.Seed(context);
            context.SaveChanges();
        }
    }
}
