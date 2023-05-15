using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFassignment.models
{
    internal class Supplier
    {
        public string SupplierName { get; set; }
        public string Address { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public string CityOperatesIn { get; set; }
        public int Id { get; set; }

    }
}
