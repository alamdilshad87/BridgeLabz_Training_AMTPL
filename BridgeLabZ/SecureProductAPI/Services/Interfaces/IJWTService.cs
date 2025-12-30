namespace SecureProductAPI.Services.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(string username, string role);
    }
}
