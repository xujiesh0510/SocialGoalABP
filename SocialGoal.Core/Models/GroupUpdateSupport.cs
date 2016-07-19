using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class GroupUpdateSupport
    {
        public int GroupUpdateSupportId { get; set; }
        public int GroupUpdateId { get; set; }
        public int GroupUserId { get; set; }
        public DateTime UpdateSupportedDate { get; set; }
    }
}
