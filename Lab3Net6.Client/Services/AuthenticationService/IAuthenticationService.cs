using Lab3Net6.Data.Models;

namespace Lab3Net6.Client.Services;
public interface IAuthenticationService
{
	Task RegisterAsync(string username, string password);
	Task LoginAsync(string username, string password);
	void Logout();
}
