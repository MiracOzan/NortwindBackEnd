using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Core.Utilities.Security.Jwt;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("name = conn") {

        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<OperationClaim> OperationClaim { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<UserForLoginDto> userForLoginDto { get; set; }
        public DbSet<UserForRegisterDto> userForRegisterDto { get; set; }

        public DbSet<TokenOptions> TokenOptions { get; set; }
        public DbSet<AccessToken> AccessToken { get; set; }
    }
}
