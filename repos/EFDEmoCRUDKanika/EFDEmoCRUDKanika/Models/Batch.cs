using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDEmoCRUDKanika.Models
{
    internal class Batch
    {
     
        public int BtachCode { get; set; }
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [MinLength(10)]
        [Column("BatchName")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public string trainer { get; set; }
    }
}
