
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDEmoCRUDKanika.Models
{
    internal class Grade
    {
        
        public int GradeCode { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
    }
}
