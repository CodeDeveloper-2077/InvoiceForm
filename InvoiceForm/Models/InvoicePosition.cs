using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceForm.Models
{
    public class InvoicePosition
    {
        public decimal InvoicePositionId { get; set; }

        public string? Name { get; set; }

        public decimal Value { get; set; }

        public decimal InvoiceId { get; set; }

        public Invoice? Invoice { get; set; }
    }
}
