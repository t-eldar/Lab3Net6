using Lab3Net6.Client.Stores;

using ServiceReference1;

namespace Lab3Net6.Client.Services;
public sealed class AuthenticationService : IAuthenticationService
{
	private readonly UserServiceClient _userServiceClient;
	private readonly AccountStore _accountStore;
	private readonly IMapper _mapper;
	public AuthenticationService(
		UserServiceClient userServiceClient, 
		AccountStore accountStore,
		IMapper mapper)
	{
		_userServiceClient = userServiceClient;
		_accountStore = accountStore;
		_mapper = mapper;
	}
	public async Task LoginAsync(string username, string password)
	{
		var response = await _userServiceClient.LogInAsync(username, password);
		var user = _mapper.MapUser(response.Data);
		_accountStore.CurrentUser = user;
	}

	public void Logout() => _accountStore.CurrentUser = null;
	public async Task RegisterAsync(string username, string password)
	{
		var response = await _userServiceClient.RegisterAsync(username, password);
		var user = _mapper.MapUser(response.Data);
		_accountStore.CurrentUser = user;
	}
}
