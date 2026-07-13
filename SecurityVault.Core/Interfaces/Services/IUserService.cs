using SecurityVault.Core.Entities;

namespace SecurityVault.Core.Interfaces.Services;

public interface IUserService
{
    Task<bool> CheckEmail(string email,CancellationToken ct);
    Task<bool> CheckUsername(string username,CancellationToken ct);
    Task<string> HashPassword(string password,CancellationToken ct);
    bool CheckPasswordRules(string password);
}