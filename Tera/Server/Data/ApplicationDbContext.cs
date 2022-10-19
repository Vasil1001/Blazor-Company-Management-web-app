using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using Tera.Server.Models;
using Tera.Shared;

namespace Tera.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        //To make a migration of new DbSet
        //add-migration AddWeatherForecastEntity
        //then to confirm changes
        //update-database
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //manually add a few entities to the db
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    CompanyId = Guid.NewGuid(),
                    companyName = "Knowledge Ai Limited",
                    companyDescription = "Knowledge Ai Limited specializes in Ai innovation and " +
                                         "research to help apply it in real life scenarios for companies to benefit " +
                                         "marketing wise and on social media.",
                    DateCreated = new DateTime(2016, 3, 27, 2, 0, 0),
                },

                new Company
                {
                    CompanyId = Guid.NewGuid(),
                    companyName = "Webcast",
                    companyDescription = "Webcast focuses on cloud services that allow users to project content such as screen sharing or video games " +
                                         "from their monitors to their living room TV using the hardware of their PC.",
                    DateCreated = new DateTime(2018, 6, 12, 2, 0, 0),
                },

                new Company
                {
                    CompanyId = Guid.NewGuid(),
                    companyName = "NIO",
                    companyDescription = "NIO is a Chinese multinational automobile manufacturer headquartered in Shanghai, specializing in designing and developing electric vehicles.",
                    DateCreated = new DateTime(2018, 6, 12, 2, 0, 0),
                }
             );

            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectId = Guid.NewGuid(),
                    Name = "Self Driving Vehicles Project",
                    Description = "Research sensors for self parking",
                    DateCreated = new DateTime(2019, 5, 22, 2, 0, 0),
                    ProjectStatus = "In Progress",
                },

                new Project
                {
                    ProjectId = Guid.NewGuid(),
                    Name = "Battery efficiency Project",
                    Description = "Research effective methods for battery efficiency, including stations for battery swapping, leaving your battery to charge for others to swap with",
                    DateCreated = new DateTime(2020, 3, 11, 2, 0, 0),
                    ProjectStatus = "In Progress",
                },

                new Project
                {
                    ProjectId = Guid.NewGuid(),
                    Name = "Neural Networks research",
                    Description = "Research Neural Networks for stock market trend analysis",
                    DateCreated = new DateTime(2021, 6, 2, 3, 0, 0),
                    ProjectStatus = "In Progress",
                },
                new Project
                {
                    ProjectId = Guid.NewGuid(),
                    Name = "Bayesian Networks",
                    Description = "Bayesian networks are a type of probabilistic graphical model that uses Bayesian inference for probability computations.",
                    DateCreated = new DateTime(2021, 9, 2, 3, 0, 0),
                    ProjectStatus = "Open",
                },
                new Project
                {
                    ProjectId = Guid.NewGuid(),
                    Name = "Machine Learning",
                    Description = "Research on: Machine learning is an application of artificial intelligence (AI) that provides systems the ability to automatically learn and improve from experience without being explicitly programmed.",
                    DateCreated = new DateTime(2017, 9, 2, 3, 0, 0),
                    ProjectStatus = "Closed",
                }
           );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "George",
                    LastName = "Rowling",
                    Email = "George@gmail.com",
                },
                new User
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "Jimmy",
                    LastName = "Ronald",
                    Email = "jron@gmail.com",
                },
                new User
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "Andy",
                    LastName = "Jermaine",
                    Email = "aj@gmail.com",
                },
                new User
                {
                    UserId = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Mar",
                    Email = "johnmar@gmail.com",
                }
            );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = Guid.NewGuid(),
                    Name = "Research hydrogen batteries long term effect on electric cars",
                    Description = "Research hydrogen batteries long term effect on electric cars and compare to current lithium used by NIO",
                    TicketCreatedDate = new DateTime(2021, 9, 28, 2, 0, 0),
                    TicketStatus = "In Progress",
                },
                new Ticket
                {
                    Id = Guid.NewGuid(),
                    Name = "Work on Bayesian networks",
                    Description = "Research Bayesian networks making a summary for our architecture",
                    TicketCreatedDate = new DateTime(202, 11, 12, 2, 0, 0),
                    TicketStatus = "In Progress",
                },
                new Ticket
                {
                    Id = Guid.NewGuid(),
                    Name = "Webcast cloud service ",
                    Description = "Work on the cloud service streaming to remote screens",
                    TicketCreatedDate = new DateTime(2021, 12, 22, 2, 0, 0),
                    TicketStatus = "Open",
                }
           );
        }

        //    modelBuilder.Entity<Company>().HasData(
        //        new Project
        //        {
        //            ProjectId = Guid.NewGuid(),
        //            Name = "Self Driving Vehicles",
        //            Description = "Knowledge Ai Limited specializes in Ai innovation and " +
        //                                 "research to help apply it in real life scenarios for companies to benefit " +
        //                                 "marketing wise and on social media.",
        //            DateCreated = new DateTime(2019, 5, 22, 2, 0, 0),
        //            ProjectStatus = "Open",
        //            CompanyId = Guid.NewGuid(),
        //
        //        }
        //     );
        //
        //    modelBuilder.Entity<Company>().HasData(
        //       new Ticket
        //       {
        //           Id = Guid.NewGuid(),
        //           Name = "research sensors",
        //           Description = "Knowledge Ai Limited specializes in Ai innovation and " +
        //                                "research to help apply it in real life scenarios for companies to benefit " +
        //                                "marketing wise and on social media.",
        //           TicketCreatedDate = new DateTime(2019, 5, 22, 2, 0, 0),
        //           TicketStatus = "Open",
        //           UserId = Guid.NewGuid(),
        //
        //       }
        //    );
        //
        //    modelBuilder.Entity<Company>().HasData(
        //       new User
        //       {
        //           UserId = Guid.NewGuid(),
        //           FirstName = "George",
        //           LastName = "Rowling",
        //           Email = "George@gmail.com",
        //       }
        //    );
        //}


    }
}
