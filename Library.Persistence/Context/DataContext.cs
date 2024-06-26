﻿using Library.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Library.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }
}
