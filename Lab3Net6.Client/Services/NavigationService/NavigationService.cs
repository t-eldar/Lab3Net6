using Lab3Net6.Client.Stores;
using Lab3Net6.Client.ViewModels;

namespace Lab3Net6.Client.Services;
public sealed class NavigationService : INavigationService
{
	private readonly NavigationStore _navigationStore;
	private readonly Func<Type, ViewModelBase> _viewModelCreator;
	public NavigationService(NavigationStore navigationStore, Func<Type, ViewModelBase> viewModelCreator)
	{
		_navigationStore = navigationStore;
		_viewModelCreator = viewModelCreator; 
	}
	public void Navigate<TViewModel>() where TViewModel : ViewModelBase
	{
		var viewModel = _viewModelCreator(typeof(TViewModel)) as TViewModel 
			?? throw new Exception("Creator function created wrong typed view model");
		_navigationStore.CurrentViewModel = viewModel;
	}
}
