using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesRenting.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int customerId { get; set; }

        public Movie Movie { get; set; }

        public int MovieId { get; set; }

        public DateTime RentDate { get; set; }

        public bool Statuas { get; set; }
    }
}