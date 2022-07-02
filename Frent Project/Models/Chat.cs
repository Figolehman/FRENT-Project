using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRENT_Project.Models
{
    public class Chat
    {
        [Key]
        public int id { get; set; }
        public int userID { get; set; }
        [ForeignKey("userID")]
        [ValidateNever]
        public int partnerID { get; set; }
        [ForeignKey("partnerID")]
        [ValidateNever]

        [Required]
        public string username { get; set; }
        [Required]
        public string fullName { get; set; }
        public string messageList { get; set; }

    }
}
