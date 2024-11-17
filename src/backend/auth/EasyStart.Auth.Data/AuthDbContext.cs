// EasyStart
// Copyright (C) 2024
// 
// This file is licensed under the GNU General Public License v3.0.
// Redistribution, modification, or use of this file is allowed according to the terms of the License.
// Full license details: https://www.gnu.org/licenses/gpl-3.0.html.
// 
// This project is open source but may transition to a paid license in the future.
// Please refer to furqata93@gmail.com for updated licensing information.

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