namespace Lab3Net6.Server.Services;

public interface IPasswordHasher
{
	string HashPassword(string password);
	bool VerifyPassword(string input, string hashed);
}
