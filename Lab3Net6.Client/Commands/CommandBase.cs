﻿using System.Windows.Input;

namespace Lab3Net6.Client.Commands;
public abstract class CommandBase : ICommand
{
	public event EventHandler? CanExecuteChanged
	{
		add => CommandManager.RequerySuggested += value;
		remove => CommandManager.RequerySuggested -= value;
	}
	public abstract bool CanExecute(object? parameter);
	public abstract void Execute(object? parameter);
}
