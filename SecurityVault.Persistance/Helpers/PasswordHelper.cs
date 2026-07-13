namespace SecurityVault.Persistance.Helpers;

public static class PasswordHelper
{
    public static bool CheckPasswordRequirement(this string password)
    {
        return password.Length <= 8;
    }
}