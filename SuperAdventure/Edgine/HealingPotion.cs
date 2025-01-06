using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgine
{
    public class HealingPotion : Item//派生类
    {
     
       public string AmountToHeal { get; set; }
       public HealingPotion(int id, string name, string namePlural, int amountToHeal)
           : base(id, name, namePlural)
       {
           AmountToHeal = amountToHeal;         //Cannot implicitly convert type "int" to "string"
       }
    }
}
