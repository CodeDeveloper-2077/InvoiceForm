using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceForm.Models
{
    public class Invoice
    {
        [Key, Column("Invoice_Id"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal InvoiceId { get; set; }

        [Required, MaxLength(20)]
        public string? Number { get; set; }

        public decimal Value { get; set; }

        public ICollection<InvoicePosition>? InvoicePositions { get; set; }

        public Invoice()
        {
            InvoicePositions = new List<InvoicePosition>();
        }
    }
}
