using System;
using System.ComponentModel.DataAnnotations;

namespace Tera.Shared
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime TicketCreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; } //? used to accept null, instead of 01/01/1111 date
        public string TicketStatus { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }

    }
}
