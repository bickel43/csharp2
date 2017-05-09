using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.BusinessObjects
{
    public class MemberClass
    {
        public int MemberNumber { get; set; }
        public string JoinDate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public bool MemberStatus { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int ContactMethod { get; set; }
        public int SubscriptionID { get; set; }
        public string Photo { get; set; }
    }
}
