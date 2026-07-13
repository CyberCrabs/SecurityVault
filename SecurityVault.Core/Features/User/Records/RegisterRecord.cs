using MediatR;
using SecurityVault.Core.Wrappers;

namespace SecurityVault.Core.Features.User.Records;

public record RegisterRecord(
    string Username,
    string Email,
    string Password) : IRequest<Result>;