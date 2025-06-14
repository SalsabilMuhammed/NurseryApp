using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Fee : BaseEntity
    {
        [StringLength(100)]
        public string? Name { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal BaseAmount { get; set; }
        public bool IsActive { get; set; } = true;  // Soft delete flag
        public DateTime EffectiveFrom { get; set; } = DateTime.Now;
        public DateTime? EffectiveTo { get; set; }  // Null = currently active

        // For classes using this fee
        public ICollection<NurseryClass> NurseryClasses { get; set; } = new List<NurseryClass>();
        // For activity fees
        public ICollection<Activity> Activities { get; set; } = new List<Activity>();
        public ICollection<PaymentRecord> Payments { get; set; } = new List<PaymentRecord>();
    }
}
