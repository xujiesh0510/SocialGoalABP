using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace SocialGoal.Models
{
    public class ApplicationUser:Entity
    {
        public int UserId { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProfilePicUrl { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public bool Activated { get; set; }

        public int RoleId { get; set; }

        public ApplicationUser()
        {
            DateCreated = DateTime.Now;
        }

        public string DisplayName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}