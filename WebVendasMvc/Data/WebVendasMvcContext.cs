﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebVendasMvc.Models;

namespace WebVendasMvc.Data
{
    public class WebVendasMvcContext : DbContext
    {
        public WebVendasMvcContext (DbContextOptions<WebVendasMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
    }
}
