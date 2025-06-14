using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Student : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        public string FatherFullName { get; set; }
        public string MotherFullName { get; set; }
        [MaxLength(20)]
        public int ParentMobilePhone1 { get; set; }
        [MaxLength(20)]
        public int ParentMobilePhone2 { get; set; }
        [Required, StringLength(20)]
        public string NationalId { get; set; }

        [Required, ForeignKey("NurseryClassId")]
        public NurseryClass NurseryClass { get; set; }
        public int NurseryClassId { get; set; }
        [StringLength(200)]
        public string? Notes { get; set; }
        public ICollection<PaymentRecord> Payments { get; set; }
        public ICollection<Activity> Activities { get; set; }
        //main monthly fees
        //or can be special fees
        // Many-to-many relationship with Activity
        // public ICollection<Activity> Activities { get; set; }
        //may declare table many to many to add more details
        //files
        //List of images
        
    }
}
