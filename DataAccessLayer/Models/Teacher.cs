using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Teacher : BaseEntity
    {
        public string FullName { get; set; }
        [MaxLength(20)]
        public int MobilePhone { get; set; }
        [MaxLength(14)]
        public int NationalId { get; set; }
        //files
        //List of images
    }
}
