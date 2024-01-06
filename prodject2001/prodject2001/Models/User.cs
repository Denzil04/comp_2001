using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prodject2001.Models
{
    public class User
    {
        public int UserId { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; } // In a real-world application, ensure this is securely hashed
        public bool Admin { get; set; }

        
    }

}
