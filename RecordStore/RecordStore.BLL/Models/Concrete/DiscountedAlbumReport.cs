using RecordStore.BLL.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.BLL.Models.Concrete
{
    public class DiscountedAlbumReport : ReportAlbumResult
    {
        public double? Discount { get; set; }
    }
}
