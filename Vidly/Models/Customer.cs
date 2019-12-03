using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Security;
using Vidly.Controllers;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
<<<<<<< Updated upstream
=======
        public bool IsSubscribedToNewsLetter { get; set; }
        public int MemberShipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }

>>>>>>> Stashed changes
    }
}