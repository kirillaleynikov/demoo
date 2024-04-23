using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public partial class ZapAndOrder
    {
        public int? ZapId { get; set; }
        public int? ReportsId { get; set; }
        public int? Counts { get; set; }

        public virtual Report? Reports { get; set; }
        public virtual Zapchasti? Zap { get; set; }
    }
}
