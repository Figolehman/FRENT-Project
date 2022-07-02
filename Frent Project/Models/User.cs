
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace FRENT_Project.Models
{
    public class User : IdentityUser
    {
        public string phone { get; set; }
        public string password { get; set; }
        public string fullName { get; set; }
        public string NIK { get; set; }
        public string city { get; set; }
        public DateTime DOB { get; set; }
        public string bio { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
