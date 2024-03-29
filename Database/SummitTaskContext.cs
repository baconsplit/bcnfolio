﻿using Microsoft.EntityFrameworkCore;

namespace Bcnfolio.Database
{
    public class SummitTaskContext : DbContext
    {
        public SummitTaskContext(DbContextOptions<SummitTaskContext> opts) : base(opts)
        { }

        public DbSet<SummitTask> SummitTasks { get; set; } = null!;
    }
}
