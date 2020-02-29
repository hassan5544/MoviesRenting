﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MoviesRenting.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        [Required]
        public bool IsSubscribedToNewsFeed { get; set; }

        public MemberShipType MemberShipType { get; set; }

        public int MemberShipTypeId { get; set; }

    }
}