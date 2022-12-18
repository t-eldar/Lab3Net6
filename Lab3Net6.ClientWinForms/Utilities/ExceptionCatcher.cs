using ServiceReference2;

using System;
using System.ServiceModel;

namespace Lab3Net6.ClientWinForms.Utilities;
public static class ExceptionCatcher
{
	public static void Catch(Action action)
	{
		try
		{
			action.Invoke();
		}
		catch (AggregateException ex)
		{
			var faultEx = ex.InnerExceptions
				.FirstOrDefault(e => e.GetType() == typeof(FaultException))
				as FaultException;
			MessageBox.Show(faultEx?.Reason.ToString());
		}
		catch (FaultException ex)
		{
			MessageBox.Show(ex.Reason.ToString());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
	public static async Task CatchAsync(Task task)
	{
		try
		{
			await task;
		}
		catch (AggregateException ex)
		{
			var faultEx = ex.InnerExceptions
				.FirstOrDefault(e => e.GetType() == typeof(FaultException))
				as FaultException;
			MessageBox.Show(faultEx?.Reason.ToString());
		}
		catch (FaultException ex)
		{
			MessageBox.Show(ex.Reason.ToString());
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}
	public static async Task<T?> CatchAsync<T>(Task<T> task) 
	{
		try
		{
			return await task;
		}
		catch (AggregateException ex)
		{
			var faultEx = ex.InnerExceptions
				.FirstOrDefault(e => e.GetType() == typeof(FaultException))
				as FaultException;
			MessageBox.Show(faultEx?.Reason.ToString());
			return default;
		}
		catch (FaultException ex)
		{
			MessageBox.Show(ex.Reason.ToString());
			return default;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
			return default;
		}
	}
}
