using Lab3Net6.Client.ViewModels;

namespace Lab3Net6.Client.Stores;
public sealed class NavigationStore
{
	private ViewModelBase? _currentViewModel;

	public ViewModelBase? CurrentViewModel
	{
		get => _currentViewModel;
		set
		{
			_currentViewModel?.Dispose();
			_currentViewModel = value;
			OnCurrentViewModelChanged();
		}
	}

	public event Action? CurrentViewModelChanged;

	private void OnCurrentViewModelChanged()
	{
		CurrentViewModelChanged?.Invoke();
	}
}
