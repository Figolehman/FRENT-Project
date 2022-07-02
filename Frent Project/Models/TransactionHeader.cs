using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRENT_Project.Models
{
    public class TransactionHeader
    {
        [Key]
        public int id { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        [ValidateNever]
        public int partnerID { get; set; }
        [ForeignKey("partnerID")]
        [ValidateNever]
        public Partner partner { get; set; }
        [Required]
        public DateTime transactionDate { get; set; }
        [Required]
        public string paymentType { get; set; }

    }
}
