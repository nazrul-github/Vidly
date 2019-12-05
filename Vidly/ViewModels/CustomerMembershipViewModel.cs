using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerMembershipViewModel
    {
        public CustomerMembershipViewModel()
        {
            Memberships = new List<MembershipType>();
        }

        public IEnumerable<MembershipType> Memberships;
        public Customer Customer { get; set; }
    }
}