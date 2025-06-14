using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Nanny : BaseEntity
    {
        [Required, StringLength(100)]
        public string Name { get; set; }
        //string for some passports Ids
        [Required, StringLength(20)]
        public string NationalId { get; set; }
        [Required, MaxLength(20)]
        public int MobilePhone { get; set; }
        [ForeignKey("NurseryClassId")]
        public NurseryClass? NurseryClass { get; set; }
        public int? NurseryClassId { get; set; }
    }
}
