using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations;


namespace ManageFlightTickets.Models
{
    public class Account
    {
        [Key]
        public string IdAccount { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentityCard { get; set; }
        
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public bool IsRole { get; set; }

    }
}
