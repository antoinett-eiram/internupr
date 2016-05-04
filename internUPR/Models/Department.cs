using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//library pk
using System.Linq;
using System.Web;

namespace internUPR.Models
{
    public class Department
    {
        [Key]
        public int departmentID { get; set; }
        public string departmentName { get; set; }
        public string dptEmphasis { get; set; }



    }
}