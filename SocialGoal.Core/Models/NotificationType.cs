using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialGoal.Models
{
    public enum NotificationType
    {
        createdGoal = 0,
        updatedGoal,
        commentedOnUpdate,
        createGroup,
        supportGoal,
        joinGroup,
        updatedGroupgoal,
        commentedonGroupUdate,
        followUser
    }
}