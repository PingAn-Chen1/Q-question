using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine
{
    public class PlayerQuest                //玩家追求
    {
        public Quest Details { get; set; }
        public bool IsCompleted { get; set; }//未遂的;布尔类型，其实可以理解为（是）1或者0（否）
        public PlayerQuest(Quest details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}