using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public partial class User
    {
        public User()
        {
            OrderIdClientNavigations = new HashSet<Order>();
            OrderIdWorckerNavigations = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Fio { get; set; }
        public string? Number { get; set; }
        public string? LoginU { get; set; }
        public string? PasswordU { get; set; }
        public int? RoleId { get; set; }

        public virtual Role? Role { get; set; }
        public virtual ICollection<Order> OrderIdClientNavigations { get; set; }
        public virtual ICollection<Order> OrderIdWorckerNavigations { get; set; }
    }
}
