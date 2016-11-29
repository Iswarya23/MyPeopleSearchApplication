using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyPeopleSearchApplication.Models
{
    public class SearchPeople
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Occupation { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Interest { get; set; }

      //public virtual SearchPeople Search { get; set; }
        public virtual ICollection<SearchPeople> SearchPeoples { get; set; }
    }
}