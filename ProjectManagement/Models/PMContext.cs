using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Models {
    public class PMContext : DbContext {

        public PMContext() { }
        public PMContext(DbContextOptions<PMContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<Resources> Resources { get; set; } = null!;
        public DbSet<Project> Projects { get; set; } = null!;
        public DbSet<Work> Works { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            var connStr = @"server=localhost\sqlexpress;database=ProjectManagement;trustServerCertificate=true;trusted_connection=true;";
            builder.UseSqlServer(connStr);

        }
    } }
