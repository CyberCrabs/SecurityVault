using MediatR;
using Microsoft.AspNetCore.Identity;
using SecurityVault.Core.Features.User.Records;
using SecurityVault.Core.Interfaces.Repositories;
using SecurityVault.Core.Interfaces.Services;
using SecurityVault.Core.Wrappers;

namespace SecurityVault.Core.Features.User.Handlers;

public class RegisterHandler(IUserService userService,IUserRepository userRepository) : IRequestHandler<RegisterRecord,Result>
{
    public async Task<Result> Handle(RegisterRecord request, CancellationToken cancellationToken)
    {
        var hashedPassword = await userService.HashPassword(request.Password,cancellationToken);
        if (hashedPassword == string.Empty)
            return Result.Failure("The user could not be created. Please try again later.");

        var newUser = new Entities.User()
        {
            Username = request.Username,
            Email = request.Email,
            Password = hashedPassword
        };
        
        userRepository.CreateUser(newUser);
        await userRepository.SaveUserChangesAsync(cancellationToken);

        return Result.Succes();
    }
}