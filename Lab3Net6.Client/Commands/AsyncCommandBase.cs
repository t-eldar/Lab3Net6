using System.Windows.Input;

namespace Lab3Net6.Client.Commands;
public abstract class AsyncCommandBase : ICommand
{
	public event EventHandler<Exception>? ExceptionThrew;

	private bool _isExecuting;
	public bool IsExecuting
	{
		get => _isExecuting;
		set
		{
			_isExecuting = value;
			CanExecuteChanged?.Invoke(this, EventArgs.Empty);
		}
	}

	public event EventHandler? CanExecuteChanged;

	public virtual bool CanExecute(object? parameter)
		=> !_isExecuting;
	public virtual async void Execute(object? parameter)
	{
		IsExecuting = true;
		try
		{
			await ExecuteAsync(parameter);
		}
		catch(Exception ex)
		{
			ExceptionThrew?.Invoke(this, ex);
		}
		IsExecuting = false;
	}
	protected abstract Task ExecuteAsync(object? parameter);
}
