using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models {
    public class Project {

        public int Id { get; set; }
        [StringLength(30)]
        public string Description { get; set; } = string.Empty;
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
        [StringLength(30)]
        public string Status { get; set; } = "NEW";
    }
}
