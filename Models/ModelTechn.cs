using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public partial class ModelTechn
    {
        public ModelTechn()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Titel { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
