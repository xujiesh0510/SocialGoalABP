using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public  class UpdateSupport
    {
        public int UpdateSupportId { get; set; }

        public int UpdateId { get; set; }

        public string UserId { get; set; }
        public DateTime UpdateSupportedDate { get; set; }
    }
}
