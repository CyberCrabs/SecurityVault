using SecurityVault.Core.Entities;

namespace SecurityVault.Core.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User?> GetUserByEmailAsync(string email,CancellationToken ct);
    Task<User?> GetUserByUsernameAsync(string username,CancellationToken ct);
    Task CreateUser(User user);
    Task SaveUserChangesAsync(CancellationToken ct);
}