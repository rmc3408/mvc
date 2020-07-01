﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SportStore.Models
{
    public class DataB : DbContext
    {
        public DataB(DbContextOptions<DataB> options) : base(options)
        {

        }
        public DbSet<Product> ProductsInDatabase { get; set; }


    }
}