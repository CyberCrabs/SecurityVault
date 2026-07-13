using System.Linq.Expressions;
using SecurityVault.Core.Entities;
using SecurityVault.Core.Interfaces;
using SecurityVault.Core.Interfaces.Repositories;
using SecurityVault.Core.Interfaces.Services;
using SecurityVault.Persistance.Data;
using SecurityVault.Persistance.Helpers;

namespace SecurityVault.Persistance.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<bool> CheckEmail(string email,CancellationToken ct)
    {
        var user = await userRepository.GetUserByEmailAsync(email,ct);
        return user != null;
    }


    public async Task<bool> CheckUsername(string username,CancellationToken ct)
    {
        var user = await userRepository.GetUserByUsernameAsync(username,ct);
        return user != null;
    }

    public Task<string> HashPassword(string password,CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public bool CheckPasswordRules(string password)
    {
        return password.CheckPasswordRequirement();
    }
}