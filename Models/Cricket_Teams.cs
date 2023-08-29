using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ps_13.Models
{
    [Table("Cricket_Teams")]
    public class Cricket_Teams
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        [StringLength(50)]
        public string TeamName { get; set; }
        [Required]
        public int NOWC { get; set; }

    }
}