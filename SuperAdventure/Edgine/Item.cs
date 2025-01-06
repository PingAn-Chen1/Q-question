using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgine
{
   public class Item
    {
        public int ID { get; set; }    //基类
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
