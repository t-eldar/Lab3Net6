using Lab3Net6.Client.Services;
using Lab3Net6.Data.Models;

namespace Lab3Net6.Client.Commands;
public class LoginAsyncCommand : AsyncCommandBase
{
	private readonly IAuthenticationService _authenticationService;
	public LoginAsyncCommand(IAuthenticationService authenticationService) 
		=> _authenticationService = authenticationService;
	protected async override Task ExecuteAsync(object? parameter)
	{
		if (parameter is not object[] values)
		{
			throw new ArgumentException("Passed parameter should contain username and password");
		}
		await _authenticationService.LoginAsync((string)values[0], (string)values[1]);
	}
}
