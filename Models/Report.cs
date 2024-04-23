using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public partial class Report
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public DateTime? DateFinish { get; set; }
        public string? Descript { get; set; }

        public virtual Order? Order { get; set; }
    }
}
