using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace internUPR.Models
{
    public class Internship
    {
        [Key]
        public int internID { get; set; }
        public string name { get; set; }
        public string departmentID { get; set; }
        public string position { get; set; }
        public string description { get; set; }
        public string requirement { get; set; }
        public string company { get; set; }
        public string contactName { get; set; }
        public string coemail { get; set; }
        public string userId { get; set; }

        //[ForeignKey("departmentID")]
       // public virtual Department deparments{get; set;}
        [ForeignKey("userId")]
        public virtual ApplicationUser user { get; set; }
    }
}