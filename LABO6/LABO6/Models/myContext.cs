﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABO6.Models
{
    public class MyContext:DbContext
    {
        public DbSet<Client> clients { get; set; }
        public MyContext(DbContextOptions <MyContext> options):base (options)


        { }
    }
}
