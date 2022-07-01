using BitirmeProjesi.Domain.Common;
using BitirmeProjesi.Domain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Domain.Entities
{
    public class ShoppingList : BaseEntity
    {
        public Category Category { get; set; }
        public string Title { get; set; }
        public List<Item> Items { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
       
        public int IsCompleted { get; set; }
    }
}
