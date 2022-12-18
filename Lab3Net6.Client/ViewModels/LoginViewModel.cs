using System.Windows.Input;

using Lab3Net6.Client.Commands;

namespace Lab3Net6.Client.ViewModels;
public sealed class LoginViewModel : ViewModelBase
{
	private string? _username;
	private string? _password;
	private string? _status;
	private LoginAsyncCommand _loginCommand;

	public LoginViewModel(LoginAsyncCommand loginAsyncCommand)
	{
		_loginCommand = loginAsyncCommand;
		_loginCommand.ExceptionThrew += (sender, exception) =>
		{
			Status = $"Возникла ошибка {exception.Message}";
		};
	}
	public LoginAsyncCommand LoginCommand => _loginCommand;
	public string? Status
	{
		get => _status;
		set
		{
			_status = value;
			OnPropertyChanged();
		}
	}
	public string? Username
	{
		get => _username;
		set
		{
			_username = value;
			OnPropertyChanged();
		}
	}
	public string? Password
	{
		get => _password;
		set
		{
			_password = value;
			OnPropertyChanged();
		}
	}

}
