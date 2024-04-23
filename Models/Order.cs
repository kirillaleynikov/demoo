using System;
using System.Collections.Generic;

namespace WinFormsApp2.Models
{
    public partial class Order
    {
        public Order()
        {
            Reports = new HashSet<Report>();
        }

        public int Id { get; set; }
        public int? Idnumber { get; set; }
        public DateTime? DateCreate { get; set; }
        public int? TypeBtTechnId { get; set; }
        public int? ModelId { get; set; }
        public string? Descr { get; set; }
        public string? Comment { get; set; }
        public int? IdClient { get; set; }
        public string? PhoneNumber { get; set; }
        public int? StatusId { get; set; }
        public int? IdWorcker { get; set; }
        public int? TypeProblem { get; set; }

        public virtual User? IdClientNavigation { get; set; }
        public virtual User? IdWorckerNavigation { get; set; }
        public virtual ModelTechn? Model { get; set; }
        public virtual Status? Status { get; set; }
        public virtual TypeBtTechn? TypeBtTechn { get; set; }
        public virtual TypeProblem? TypeProblemNavigation { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
