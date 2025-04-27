using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string FatherFullName { get; set; }
        public string MotherFullName { get; set; }
        [MaxLength(20)]
        public int ParentMobilePhone1 { get; set; }
        [MaxLength(20)]
        public int ParentMobilePhone2 { get; set; }
        [MaxLength(14)]
        public int NationalId { get; set; }
        //files
        //List of images
        //fees
    }
}
