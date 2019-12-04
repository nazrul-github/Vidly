using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public int SignUpFee { get; set; }
        public int DurationInMonths { get; set; }
        public int DiscountRate { get; set; }
        [DisplayName("Membership Name")]
        public string MembershipName { get; set; }
    }
}