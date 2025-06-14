using DataAccessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer.Models
{
    public class NurseryClass : BaseEntity
    {
        [StringLength(50)]
        public string ClassName { get; set; }

        [Required]
        public ClassLevel Level { get; set; }

        [ForeignKey("ActiveFeeId")]
        public Fee? ActiveFee { get; set; }  // Current active fee
        public int? ActiveFeeId { get; set; } // Ensures one active fee per class

        [Required]
        public Teacher Teacher { get; set; }
        public ICollection<Nanny> Nannies { get; set; }
        public ICollection<Student> Students { get; set; }

    }
}
