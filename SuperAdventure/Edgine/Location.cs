using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgine
{
   public class Location       //普通类 
    {
        public int ID { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }



       public Location(int id, string name, string description)//构造函数
       {
           ID = id;
           Name = name;
           Description = description;
       }
    }
}
