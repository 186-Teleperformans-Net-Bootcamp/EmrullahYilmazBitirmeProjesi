using BitirmeProjesi.Domain.Common;
using BitirmeProjesi.Domain.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi.Domain.Entities
{
    public class List : BaseEntity
    {
        public Category Category { get; set; }
        public string Title { get; set; }
        public Item Item { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public class Declare
        {
            public Type Type { get; set; }

        }
        public enum Type { Kilogram, Litre, Adet }
       
        public int IsCompleted { get; set; }
    }
}
