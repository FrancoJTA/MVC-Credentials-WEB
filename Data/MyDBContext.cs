using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace cpDan.Data;

public class MyDBContext : IdentityDbContext<IdentityUser>
{ 
    public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
}