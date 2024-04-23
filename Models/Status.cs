using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Titel { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
