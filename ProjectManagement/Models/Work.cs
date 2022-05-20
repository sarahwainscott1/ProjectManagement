using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models {
    public class Work {

        public int Id { get; set; }
        [StringLength(30)]
        public string Description { get; set; } = string.Empty;
        public int HoursWorked { get; set; } = 0;
        public int ResourceId { get; set; } = 0;
        public Resources? Resources { get; set; } = null;
    }
}
