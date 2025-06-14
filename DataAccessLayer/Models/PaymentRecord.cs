using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class PaymentRecord : BaseEntity
    {
        [Required, ForeignKey("FeeId")]
        public Fee Fee { get; set; }
        public int FeeId { get; set; }

        [Required, ForeignKey("StudentId")]
        public Student Student { get; set; }
        public int StudentId { get; set; }

        [Required, Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [StringLength(200)]
        public string? Notes { get; set; }
    }
}
