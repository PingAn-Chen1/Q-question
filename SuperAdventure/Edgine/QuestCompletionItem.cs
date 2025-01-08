using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Engine
{
    public class QuestCompletionItem//任务完成项目
    {
        public Item Details { get; set; }
        public int Quantity { get; set; }//数目
        public QuestCompletionItem(Item details, int quantity)//构造函数
        {
            Details = details;
            Quantity = quantity;
        }
    }
}