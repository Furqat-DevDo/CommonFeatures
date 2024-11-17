// EasyStart - Copyright (C) 2024. GNU GPL v3.0.
// Terms: https://www.gnu.org/licenses/gpl-3.0.html.
// Contact: furqata93@gmail.com.

using EasyStart.Auth.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyStart.Auth.Data;

public class AuthDbContext : IdentityDbContext<IdentityUserExtension,IdentityRoleExtension,Guid>
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
    {
        
    }
}