using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public DateTime? BirthDate { get; set; }
        public int MembershipId { get; set; }
        [ForeignKey("MembershipId")]
        public MembershipType MembershipType { get; set; }

    }
}