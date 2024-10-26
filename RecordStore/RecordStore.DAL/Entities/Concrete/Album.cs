using RecordStore.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.DAL.Entities.Concrete
{
    public class Album : BaseEntity
    {
        public string Name { get; set; }
        public string Singers { get; set; }
        public DateOnly PublishedDate { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public bool IsActive { get; set; }
    }
}
