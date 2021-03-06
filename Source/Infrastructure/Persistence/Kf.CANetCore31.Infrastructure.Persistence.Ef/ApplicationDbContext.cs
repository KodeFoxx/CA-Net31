﻿using Kf.CANetCore31.Core.Application;
using Kf.CANetCore31.Core.Domain.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Kf.CANetCore31.Infrastructure.Persistence.Ef
{
    public sealed class ApplicationDbContext
        : DbContext, IReadWriteApplicationDbContext
    {
        private readonly ILogger<ApplicationDbContext> _logger;

        public ApplicationDbContext(
            ILogger<ApplicationDbContext> logger,
            DbContextOptions options)
            : base(options)
            => _logger = logger;
        public ApplicationDbContext(
            DbContextOptions options)
            : base(options)
        { }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.ConfigureSeed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
