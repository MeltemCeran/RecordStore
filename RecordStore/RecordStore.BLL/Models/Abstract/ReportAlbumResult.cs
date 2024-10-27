using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.BLL.Models.Abstract
{
    public abstract class ReportAlbumResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Singers { get; set; }
    }

}
