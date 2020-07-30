using System;
using System.Collections.Generic;
using System.Text;
using KorvMackaMedOst.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KorvMackaMedOst.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
    } 
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
