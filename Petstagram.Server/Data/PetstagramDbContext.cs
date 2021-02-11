using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petstagram.Server.Data
{
    public class PetstagramDbContext : IdentityDbContext
    {
        public PetstagramDbContext(DbContextOptions<PetstagramDbContext> options)
            : base(options)
        {
        }
    }
}
