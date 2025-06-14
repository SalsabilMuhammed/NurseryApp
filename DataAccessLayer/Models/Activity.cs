using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Activity : BaseEntity
    {
        [Required, StringLength(100)]
        public string ActivityName { get; set; }
        [StringLength(200)]
        public string? Notes { get; set; }
        [ForeignKey("FeeId")]
        public Fee? Fee { get; set; }
        public int? FeeId { get; set; }
        public ICollection<Student> Participants { get; set; }
        //person responsible for activity
    }
}
