using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stillborn.Web
{
    public class BumContext : IdentityDbContext<User>
    {
        public BumContext(DbContextOptions options) : base(options)
        {
        }
    }
}
