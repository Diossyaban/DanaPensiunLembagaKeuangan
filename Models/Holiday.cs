using System;
using System.Collections.Generic;

#nullable disable

namespace DPLK.Models
{
    public partial class Holiday
    {
        public DateTime HolidayDt { get; set; }
        public string Comment { get; set; }
        public DateTime LastChangeDt { get; set; }
    }
}
