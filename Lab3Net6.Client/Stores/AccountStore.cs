using Lab3Net6.Data.Models;

namespace Lab3Net6.Client.Stores;
public sealed class AccountStore
{
	private User? _currentUser;
	public User? CurrentUser
	{
		get => _currentUser;
		set
		{
			_currentUser = value;
			CurrentUserChanged?.Invoke();
		}
	}
	public event Action? CurrentUserChanged;
	public void Logout()
	{
		CurrentUser = null;
	}
}
