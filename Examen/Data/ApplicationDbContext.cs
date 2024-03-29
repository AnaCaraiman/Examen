﻿using Examen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Examen.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
