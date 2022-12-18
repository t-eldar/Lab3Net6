using System.ServiceModel;

using Lab3Net6.ClientWinForms.Utilities;

using ServiceReference1;

namespace Lab3Net6.ClientWinForms;

public partial class LoginForm : Form
{
	private readonly UserServiceClient _userServiceClient;
	private bool _isRegistered;
	private User? _user;
	public LoginForm()
	{
		InitializeComponent();
		_userServiceClient = new UserServiceClient(
			UserServiceClient.EndpointConfiguration.BasicHttpBinding_IUserService, 
			"http://localhost:5000/UserService/basichttp");
		_isRegistered = true;
	}
	private string? _username => usernameTextBox.Text;
	private string? _password => passwordTextBox.Text;
	private async void mainButton_Click(object sender, EventArgs e)
	{
		if (!_isRegistered)
		{
			_user = await ExceptionCatcher.CatchAsync(
				_userServiceClient.RegisterAsync(_username, _password));
		}
		else
		{
			_user = await ExceptionCatcher.CatchAsync(
				_userServiceClient.LogInAsync(_username, _password));
		}
		if (_user is not null)
		{
			var form = new TodoListForm(_user);
			form.Show();
			form.FormClosed += (s, e) => Close();
			Hide();
		}
	}

	private void isRegisteredLabel_Click(object sender, EventArgs e)
	{
		if (_isRegistered)
		{
			mainLabel.Text = "Регистрация";
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;
			isRegisteredLabel.Text = "Уже зарегистрирован";
			mainButton.Text = "Зарегистрироваться";
			_isRegistered = false;
			return;
		}
		mainLabel.Text = "Вход";
		usernameTextBox.Text = string.Empty;
		passwordTextBox.Text = string.Empty;
		mainButton.Text = "Войти";
		isRegisteredLabel.Text = "Зарегистрироваться";
		_isRegistered = true;
	}
}
