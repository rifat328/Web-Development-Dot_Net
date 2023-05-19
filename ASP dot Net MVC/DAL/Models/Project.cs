using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
  public  class Project
  {
        
        
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required, StringLength(150)]
        public string Status { get; set; }
        [Required, StringLength(150)]
        public string StartDate { get; set; }
        [Required, StringLength(150)]
        public string EndDate { get; set; }
        public virtual ICollection<Members> Members{ get; }
            public Project()
            {
                Members = new List<Members>();
            }
        
  }
}
