using System.ComponentModel.DataAnnotations;

namespace SmartMes.Models
{
    public class SmartUser
    {
        [Key]
        public string UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        [Required]
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
    }
}