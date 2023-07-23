using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class MembershipType
    {
        public string Name { get; set; }
        [Required]
        public byte Id { get; set; }
        public short SignUpFree { get; set; }
        public byte DuretionInMonth { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 0;

    }
}