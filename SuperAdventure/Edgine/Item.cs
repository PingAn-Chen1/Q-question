using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Item//基类，                           某些东西的名字，ID等，可以是玩家，小怪，也可以是道具，武器等等，都有ID，Name，和NamePlural
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        public Item(int id, string name, string namePlural)
        {
            ID = id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}