using Lab3Net6.Client.ViewModels;

namespace Lab3Net6.Client.Services;
public interface INavigationService
{
	void Navigate<TViewModel>() where TViewModel : ViewModelBase;
}
