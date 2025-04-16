using System.ComponentModel.DataAnnotations;

namespace WebApp2ByAmrit.Models
{
    public class Student
    {
        [Required]
        public int StdID { get; set; }

        [Required, StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Faculty { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, RegularExpression(@"^\d{10}$")]
        public string PhoneNumber { get; set; }
    }
} 