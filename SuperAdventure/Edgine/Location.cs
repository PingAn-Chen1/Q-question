using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location       //普通类 ；/位置
    {
         public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }//这里往下就用的不是int、string之类的默认参数了，是在一个类中创建一个属性，这个属性使用你的 其他类之一 作为它的数据类型。
                                                                                                                                     //一类套一类
        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }



       public Location(int id, string name, string description,
           Item itemRequiredToEnter = null, Quest questAvailableHere = null, Monster monsterLivingHere = null)//构造函数，“=Null”既缺省值
       {                                                                                                       //有的地方不需要某些类，所以直接传缺省值
           ID = id;
           Name = name;
           Description = description;
           ItemRequiredToEnter = itemRequiredToEnter;
           QuestAvailableHere = questAvailableHere;
           MonsterLivingHere = monsterLivingHere;
       }
    }
}
