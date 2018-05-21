﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vapor.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public string BirthDate { get; set; }

        public bool IsSubscribedToNewletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]

        public byte MembershipTypeId { get; set; }
    }
}