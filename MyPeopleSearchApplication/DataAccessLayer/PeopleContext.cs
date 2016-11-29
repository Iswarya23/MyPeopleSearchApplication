using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MyPeopleSearchApplication.Models;

namespace MyPeopleSearchApplication.DataAccessLayer
{
    public class PeopleContext: DbContext
    {
        public PeopleContext() : base("PeopleContext")
        {
        }

        public DbSet<SearchPeople> SearchPeoples { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}