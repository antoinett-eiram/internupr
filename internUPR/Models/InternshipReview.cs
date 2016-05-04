using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace internUPR.Models
{
    public class InternshipReview
    {
        [Key]
        public string internshipName { get; set; }
        public string coName { get; set; }
        public string position { get; set; }
        public string description { get; set; }
        public string experience { get; set; }
        public int rating { get; set; }

        //[ForeignKey("departmentID")]
        // public virtual Department deparments{get; set;}
        [ForeignKey("userId")]
        public virtual ApplicationUser user { get; set; }
    }
}