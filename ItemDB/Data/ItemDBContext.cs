#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemDB.Models;

    public class ItemDBContext : DbContext
    {
        public ItemDBContext (DbContextOptions<ItemDBContext> options)
            : base(options)
        {
        }

        public DbSet<ItemDB.Models.item> item { get; set; }

        public DbSet<ItemDB.Models.order> order { get; set; }

        public DbSet<ItemDB.Models.recipient> recipient { get; set; }
    }
