﻿using RecordStore.BLL.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordStore.BLL.Models.Concrete
{
    public class IsActiveAlbumReport : ReportAlbumResult
    {
        public bool IsActive { get; set; }
    }
}
