using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFassignment.models
{
    internal class Inventory
    {
        public string Name { get; set; }

        public string Details { get; set; }

        public int QtyInStock { get; set; }

        public DateTime LastUpdated { get; set; }
        public int Id { get; set; }
    }
}
