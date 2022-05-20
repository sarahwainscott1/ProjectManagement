using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models {
    public class Resources {

        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public int HoursPerDay { get; set; } = 0;
        public int? ProjectId { get; set; } = null!;
        public Project? Project { get; set; } = null!;
        public IEnumerable<Work>? Works { get; set; } = null!;
    }
}
