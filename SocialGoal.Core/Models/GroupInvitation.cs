﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
    public class GroupInvitation
    {
        public int GroupInvitationId { get; set; }
        public string FromUserId { get; set; }
        public int GroupId { get; set; }
        public string ToUserId { get; set; }
        public DateTime SentDate { get; set; }
        public bool Accepted { get; set; }
    }
}
