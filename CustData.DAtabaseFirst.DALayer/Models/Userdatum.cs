using System;
using System.Collections.Generic;

#nullable disable

namespace CustData.DAtabaseFirst.DALayer.Models
{
    public partial class Userdatum
    {
        public decimal UserId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public decimal Phone { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Purpose { get; set; }
    }
}
