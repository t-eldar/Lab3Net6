namespace Lab3Net6.Client.Commands;
public class RelayCommand : CommandBase
{
	private Action<object?> _execute;
	private Func<object?, bool>? _canExecute;
	public RelayCommand(Action<object?> execute, Func<object?, bool>? canExecute = null)
	{
		_execute = execute;
		_canExecute = canExecute;
	}
	public override bool CanExecute(object? parameter) => _canExecute is null || _canExecute(parameter);
	public override void Execute(object? parameter) => _execute(parameter);
}
