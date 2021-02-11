using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Petstagram.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Petstagram.Server.Data
{
    public class PetstagramDbContext : IdentityDbContext<User>
    {
        public PetstagramDbContext(DbContextOptions<PetstagramDbContext> options)
            : base(options)
        {
        }
    }
}
