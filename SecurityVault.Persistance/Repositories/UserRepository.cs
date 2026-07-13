using Microsoft.EntityFrameworkCore;
using SecurityVault.Core.Entities;
using SecurityVault.Core.Interfaces.Repositories;
using SecurityVault.Persistance.Data;

namespace SecurityVault.Persistance.Repositories;

public class UserRepository(AppDbContext context) : IUserRepository
{
    public async Task<User?> GetUserByEmailAsync(string email,CancellationToken ct)
    {
        return await context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<User?> GetUserByUsernameAsync(string username, CancellationToken ct)
    {
        return await context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task CreateUser(User user)
    {
        await context.Users.AddAsync(user);
    }

    public async Task SaveUserChangesAsync(CancellationToken ct)
    {
        await context.SaveChangesAsync(ct);
    }
}