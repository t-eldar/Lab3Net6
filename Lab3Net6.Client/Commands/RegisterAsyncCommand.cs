using Lab3Net6.Client.Services;

namespace Lab3Net6.Client.Commands;
public class RegisterAsyncCommand : AsyncCommandBase
{
	private readonly IAuthenticationService _authenticationService;
	public RegisterAsyncCommand(IAuthenticationService authenticationService)
		=> _authenticationService = authenticationService;
	protected override async Task ExecuteAsync(object? parameter)
	{
		if (parameter is not object[] values)
		{
			throw new ArgumentException("Passed parameter should contain username and password");
		}
		await _authenticationService.RegisterAsync((string)values[0], (string)values[1]);
	}
}
