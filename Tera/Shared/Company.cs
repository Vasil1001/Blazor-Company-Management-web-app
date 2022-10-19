using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tera.Shared
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }
        public string companyName { get; set; }
        public string companyDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Project> ProjectsList { get; set; }

        public Company()
        {
        }

    }
}

//create company, many companies
//on project, fetch company list, create project
//list companies, select company from list
//post/add project to company from list