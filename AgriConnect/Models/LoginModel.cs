using System.ComponentModel.DataAnnotations;

namespace AgriEnergy.Models
{
    public class LoginModel
    {
        
        [Required] //its a mandotory string property that the application requires to run
        public required string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]  ///this annotation tells the system to treat this string as a password type, 'hiding'it 
        public required string Password { get; set; }

    }
}
