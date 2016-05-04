using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace internUPR.Models
{
    public class Profile
    {
        [Key]
        public string full_Name { get; set; }
        public string contact_Number { get; set; }
        public string email { get; set; }
        public string department { get; set; }
        public string company_Or_Student { get; set; }
        public string Notified_Yes_No { get; set; }

        //[ForeignKey("departmentID")]
        // public virtual Department deparments{get; set;}
        [ForeignKey("userId")]
        public virtual ApplicationUser user { get; set; }
    }
}