using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public partial class TypeProblem
    {
        public TypeProblem()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
