using Lab3Net6.Client.Commands;

namespace Lab3Net6.Client.ViewModels;
public class RegisterViewModel : ViewModelBase
{ 
	private readonly RegisterAsyncCommand _registerCommand;
	private string? _username;
	private string? _password;
	public RegisterViewModel(RegisterAsyncCommand registerCommand) 
		=> _registerCommand = registerCommand;
	public RegisterAsyncCommand RegisterCommand => _registerCommand;
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
