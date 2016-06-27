using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
   public class Focus
    {
        public int FocusId { get; set; }
        public string FocusName { get; set; }
        public string Description { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
        public DateTime CreatedDate { get; set; }

       public Focus()
       {
            CreatedDate = DateTime.Now;
        }
    }
}
