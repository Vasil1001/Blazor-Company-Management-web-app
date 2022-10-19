using System;
using System.ComponentModel.DataAnnotations;

namespace Tera.Shared
{
    public class Project
    {
        [Key]
        public Guid ProjectId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]

        public string Description { get; set; }
        public string ProjectStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? ClosedDate { get; set; } //? used to accept null, instead of 01/01/1111 date
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }

        public Project()
        {
        }


    }
}
