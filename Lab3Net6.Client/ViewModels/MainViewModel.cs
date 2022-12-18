using Lab3Net6.Client.Stores;

namespace Lab3Net6.Client.ViewModels;

public sealed class MainViewModel : ViewModelBase
{
	//private readonly NavigationStore _navigationStore;
	//public ViewModelBase? ContentViewModel => _navigationStore.CurrentViewModel;

	//public MainViewModel(NavigationStore navigationStore)
	//{
	////	_navigationStore = navigationStore;
	////	_navigationStore.CurrentViewModelChanged += OnContentChanged;
	////}

	//private void OnContentChanged()
	//{
	//	OnPropertyChanged(nameof(ContentViewModel));
	//}

	private ViewModelBase? _contentViewModel;
	public ViewModelBase? ContentViewModel
	{
		get => _contentViewModel;
		set
		{
			_contentViewModel = value;
			OnPropertyChanged();
		}
	}
	private Func<LoginViewModel> _createLoginViewModel;
	private Func<RegisterViewModel> _createRegisterViewModel;

	public MainViewModel(Func<LoginViewModel> createLoginViewModel, Func<RegisterViewModel> createRegisterViewModel)
	{
		_createLoginViewModel = createLoginViewModel;
		_createRegisterViewModel = createRegisterViewModel;
	}
}
