using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
    public class UserProfile
    {
        public UserProfile()
        {
            DateEdited = DateTime.Now;
        }

        public int UserProfileId { get; set; }
        public DateTime DateEdited { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public double? ZipCode { get; set; }
        public double? ContactNo { get; set; }
        public string UserId { get; set; }
    }
}