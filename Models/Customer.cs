using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Customer
    {
        public int id { get; set; }

        //to make not nullable?
        [Required(ErrorMessage = "Pleasw, enter customer`s name.")]
        //to make max length
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership type")]
        public byte? MembershipTypeId { get; set; }

        [Display(Name = "Date of birth")]
        [Min18YearsIfMember]
        public DateTime? Birthdate { get; set; }
    }
}