using System;
using System.ComponentModel.DataAnnotations;

namespace Tera.Shared
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        //public List<Ticket> TicketsList { get; set; }

    }
}
