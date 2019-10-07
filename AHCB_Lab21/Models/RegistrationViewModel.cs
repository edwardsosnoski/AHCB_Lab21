using System;
namespace AHCB_Lab21.Models
{
    public class RegistrationViewModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool OptIn { get; set; }
    }
}