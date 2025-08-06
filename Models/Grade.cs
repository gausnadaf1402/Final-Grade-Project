using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesGradeApp.Models
{
    public class Grade
    {
        public int GradeID { get; set; } // if you ever load/edit
        public string GradeName { get; set; } = "";
        public string Description { get; set; } = "";
        public bool ActiveStatus { get; set; }
        public DateTime CreatedDate { get; set; } // filled by DB
        public string CreatedBy { get; set; } = "";
        public DateTime ModifiedDate { get; set; } // filled by DB
        public string ModifiedBy { get; set; } = "";
        public bool IsDeleted { get; set; }
    }
}
