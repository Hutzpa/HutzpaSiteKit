using HutzpaSiteKit.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HutzpaSiteKit.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        /// <summary>
        /// To initalize the database, you should call the  The "Package manager console"
        /// Then write  Add-Migration YOUR_MIGRATION_NAME
        /// Afterwars, write update-database
        /// </summary>
        /// <param name="options"></param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //Literally your tables
        public new DbSet<User> Users { get; set; }

        public DbSet<CompositeKeyEntityExample> CompositeKeyEntityExamples { get; set; }

        public DbSet<EntityExample> EntityExamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            //Composite key entity key setting
            builder.Entity<CompositeKeyEntityExample>().HasKey(o => new { o.EntityExampleId, o.UserId });
        }
    }
}
