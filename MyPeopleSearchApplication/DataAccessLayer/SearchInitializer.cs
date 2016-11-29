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
            new SearchPeople{FirstName="Nila",LastName="Alexander",Occupation="fgfdg",City="xxx",State="sdfdf",Country="dfsd",Age=Convert.ToInt16(22),Gender="sdfdsf",Interest="dfsdfs"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgsdf",City="xxx",State="sdf",Country="dsfsdf",Age=Convert.ToInt16(22),Gender="dsfsd",Interest="dsfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgfdg",City="xxx",State="dsfdsf",Country="sdfsd",Age=Convert.ToInt16(22),Gender="sdfsdf",Interest="sdfdsf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgfdg",City="xxx",State="sfd",Country="dsfdsf",Age=Convert.ToInt16(22),Gender="dfsd",Interest="dsfdsf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgfdg",City="xxx",State="dsf",Country="dsfsdf",Age=Convert.ToInt16(22),Gender="sdfsd",Interest="dsfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgfdg",City="xxx",State="sdf",Country="dfds",Age=Convert.ToInt16(22),Gender="dsfsd",Interest="dsfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgfdg",City="xxx",State="sdfsdf",Country="dsfds",Age=Convert.ToInt16(22),Gender="sdf",Interest="dfdsf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgfdg",City="xxx",State="sdf",Country="dsfdsf",Age=Convert.ToInt16(22),Gender="dfsd",Interest="dsfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="fgfdg",City="xxx",State="dfsdf",Country="dfds",Age=Convert.ToInt16(22),Gender="dfds",Interest="dfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="dfdsf",City="xxx",State="sdfadsf",Country="sdfsdf",Age=Convert.ToInt16(22),Gender="sdfdsf",Interest="dsfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="sdf",City="xxx",State="dfsdf",Country="dsfdsf",Age=Convert.ToInt16(22),Gender="dfdsf",Interest="dsfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="dsf",City="xxx",State="sdfsdf",Country="dfsd",Age=Convert.ToInt16(22),Gender="ddfs",Interest="dsfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="dsf",City="xxx",State="dsf",Country="dsfdsf",Age=Convert.ToInt16(22),Gender="dfsdf",Interest="dfsdf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="sdf",City="xxx",State="dsf",Country="sdfdsf",Age=Convert.ToInt16(22),Gender="sdfdsf",Interest="dsfdsf"},
            new SearchPeople{FirstName="Carson",LastName="Alexander",Occupation="sdf",City="xxx",State="sdf",Country="sdfsd",Age=Convert.ToInt16(22),Gender="dssdf",Interest="dfsdf"}
            };

           
            searchppl.ForEach(s => context.SearchPeoples.Add(s));
           context.SaveChanges();
        }
    }
}