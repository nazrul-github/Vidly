using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.BLL;
using Vidly.Models;

namespace Vidly.DtoS
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

      //  [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public int MembershipId { get; set; }

      
    }
}