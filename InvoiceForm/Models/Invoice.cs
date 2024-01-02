using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceForm.Models
{
    public class Invoice
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Invoice_Id { get; set; }

        [Required, MaxLength(20)]
        public string? Number { get; set; }

        public decimal Value { get; set; }

        public InvoicePosition? InvoicePosition { get; set; }
    }
}
