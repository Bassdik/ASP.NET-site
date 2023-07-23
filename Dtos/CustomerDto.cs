using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Dtos
{
    public class CustomerDto
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Pleasw, enter customer`s name.")]
        //to make max length
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        //public MembershipType MembershipType { get; set; }

        //[Display(Name = "Membership type")]
        public byte? MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Display(Name = "Date of birth")]
        //[Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}