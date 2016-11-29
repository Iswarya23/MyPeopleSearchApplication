using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPeopleSearchApplication.Models;

namespace MyPeopleSearchApplication.DataAccessLayer
{
    public class SearchInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PeopleContext>
    {
        protected override void Seed(PeopleContext context)
        {
            var searchppl = new List<SearchPeople>
            {
            new SearchPeople{FirstName="Nicole",LastName="Alexander",Occupation="Business",City="xxx",State="FL",Country="US",Age=Convert.ToInt16(22),Gender="Female",Interest="Travel"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="Teacher",City="xxx",State="UT",Country="US",Age=Convert.ToInt16(22),Gender="Male",Interest="Reading"},
            new SearchPeople{FirstName="Barrack",LastName="Obama",Occupation="President",City="xxx",State="DC",Country="US",Age=Convert.ToInt16(54),Gender="Male",Interest="Sports"}
            };

           
            searchppl.ForEach(s => context.SearchPeoples.Add(s));
           context.SaveChanges();
        }
    }
}