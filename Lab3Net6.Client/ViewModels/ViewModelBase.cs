using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab3Net6.Client.ViewModels;
public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
{
	public void Dispose() { }

	public event PropertyChangedEventHandler? PropertyChanged;
	public void OnPropertyChanged([CallerMemberName] string property = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}
