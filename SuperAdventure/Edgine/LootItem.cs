using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class LootItem            //战利品项
    {
        public Item Details { get; set; }//细节
        public int DropPercentage { get; set; }//下降的百分比
        public bool IsDefaultItem { get; set; }//是默认项,布尔类型，在完成之前一直是flase，直到完成才变成ture
        public LootItem(Item details, int dropPercentage, bool isDefaultItem)//构造函数
        {
            Details = details;
            DropPercentage = dropPercentage;
            IsDefaultItem = isDefaultItem;
        }

    }
}
