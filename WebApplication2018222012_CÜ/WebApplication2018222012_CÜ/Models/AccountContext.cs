﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2018222012_CÜ.Models
{
    public class AccountContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
    }
}