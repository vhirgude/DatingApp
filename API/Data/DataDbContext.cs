﻿using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;
public class DataDbContext : DbContext
{
    public DataDbContext(DbContextOptions<DataDbContext> options)
        : base(options)
    {
    }

    public DbSet<AppUser> Users { get; set; }





}
