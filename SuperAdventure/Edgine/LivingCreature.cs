using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edgine
{
    public class LivingCreature    //基类
    {
       public int CurrentHitPoints { get; set; }
       public int MaximumHitPoints { get; set; }
       public LivingCreature(int currentHitPoints, int maximumHitPoints)
       {
           CurrentHitPoints = currentHitPoints;
           MaximumHitPoints = maximumHitPoints;
       }

    }
}
