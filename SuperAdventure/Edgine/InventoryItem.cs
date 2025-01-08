using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine
{
    public class InventoryItem         //存储系统；仓库
    {
        public Item Details { get; set; }//项目详情：指有关项目的详细信息。
        public int Quantity { get; set; }//某种道具的数量，药水，武器等等......
        public InventoryItem(Item details, int quantity)     //构造函数
        {
            Details = details;
            Quantity = quantity;
        }
    }
}