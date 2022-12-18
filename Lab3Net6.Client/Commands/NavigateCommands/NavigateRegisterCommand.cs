using Lab3Net6.Client.Services;
using Lab3Net6.Client.ViewModels;

namespace Lab3Net6.Client.Commands;
public class NavigateRegisterCommand : CommandBase
{
	private readonly INavigationService _navigationService;

	public NavigateRegisterCommand(INavigationService navigationService)
	{
		_navigationService = navigationService;
	}
	public override bool CanExecute(object? parameter) => true;
	public override void Execute(object? parameter)
	{
		if (parameter is not Type type)
		{
			throw new ArgumentException("Passed parameter should be of Type type");
		}
		_navigationService.Navigate<RegisterViewModel>();
	}
}

