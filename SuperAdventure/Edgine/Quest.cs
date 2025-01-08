using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine
{
    public class Quest//普通类
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }//描述
        public int RewardExperiencePoints { get; set; }       //收到的经验点数
        public int RewardGold { get; set; }//收到的金币
        public Item RewardItem { get; set; }//储存玩家完成任务时收到的道具
        public List<QuestCompletionItem> QuestCompletionItems { get; set; }//列表

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold)           //构造函数
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItems = new List<QuestCompletionItem>();
        }
    }
}