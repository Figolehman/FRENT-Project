using System.ComponentModel.DataAnnotations;

namespace FRENT_Project.Models
{
    public class Partner
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public string bio { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string gender { get; set; }
        [Required]
        public int chargePerHour { get; set; }
        [Required]
        public int chargePerDay { get; set; }
        [Required]
        public DateTime schedule { get; set; }

    }
}
