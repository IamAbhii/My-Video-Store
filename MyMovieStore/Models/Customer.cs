﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMovieStore.Models 
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter Name")] 
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership type")]
        public byte MembershipTypeId { get; set; }
        [Display(Name="Date Of Birth")]
        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}