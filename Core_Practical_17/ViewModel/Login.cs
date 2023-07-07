using System.ComponentModel.DataAnnotations;

namespace Core_Practical_17.ViewModel
{
    public class Login
    {

        
        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

    }
}
