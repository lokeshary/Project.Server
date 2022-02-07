using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Shared
{
   public class Status
    {
        [Key]
        public int Sid { get; set; }

        [Required]
        public String InvoiceStatus { get; set; }
    }
}
