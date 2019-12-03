using System.Collections.Generic;

namespace Vidly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        public List<Customer> Customers { get; set; }
    }
}