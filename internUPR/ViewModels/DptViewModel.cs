using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace internUPR.ViewModels
{
    public class DptViewModel
    {
        private readonly List<internUPR.Models.Department> _deparments;
        [Display(Name = "Departamento")]
        public int SelectedDeptId { get; set; }

        public IEnumerable<SelectListItem> DeptItems
        {
            get { return new SelectList(_deparments, "departmentId", "departmentName"); }
        }
    }
}