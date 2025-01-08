using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature     //玩家       LivingCreature的派生类
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public List<InventoryItem> Inventory { get; set; }//list<>  是构造列表的方法
        public List<PlayerQuest> Quests { get; set; }//list ：构造一个以“InventoryItem”为类型的列表（带头双循环链表） 命名为Quests
        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level)
            : base(currentHitPoints, maximumHitPoints)//LivingCreature的派生类
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
            Inventory = new List<InventoryItem>();//;这段C#代码定义了一个名为 Inventory 的列表，该列表用于存储 InventoryItem 类型的对象。
            Quests = new List<PlayerQuest>();//Quests是列表的名称
        }
    }
}