using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Activity
    {
        public string ActivityName { get; set; }
        public int? TeacherId { get; set; }
        public int StudentId { get; set; }
        public float ActivityFees { get; set; }
    }
}
