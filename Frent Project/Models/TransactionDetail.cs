using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRENT_Project.Models
{
    public class TransactionDetail
    {
        [Key]
        public int transactionID { get; set; }
        [ForeignKey("transactionID")]
        [ValidateNever]
        public TransactionHeader th { get; set; }
        [Required]
        public DateTime startRent { get; set; }
        [Required]
        public string duration { get; set; }
    }
}
