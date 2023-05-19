using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
   public class Members
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Role { get; set; }
        [Required, StringLength(150)]
        public string Name { get; set; }

        [Required, ForeignKey("Project")]
        public int CId { get; set; }

        public virtual Project Project { get; set; }
    }
}
