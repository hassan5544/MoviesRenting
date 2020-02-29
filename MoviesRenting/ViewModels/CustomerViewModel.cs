using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesRenting.Models;
namespace MoviesRenting.ViewModels
{
    public class CustomerViewModel
    {
        public List<MemberShipType> MemberShipType { get; set; }
        public List<Customer> Customer { get; set; }
    }
}