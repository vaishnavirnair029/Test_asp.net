using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class LoginViewModel
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
    }
}
