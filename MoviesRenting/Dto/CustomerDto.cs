using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesRenting.Models;

namespace MoviesRenting.Dto
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsFeed { get; set; }

        public int MemberShipTypeId { get; set; }
    }
}