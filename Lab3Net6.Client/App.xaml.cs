using System.Windows;

using Lab3Net6.Client.ViewModels;

using Microsoft.Extensions.DependencyInjection;


namespace Lab3Net6.Client;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	public IServiceProvider ServiceProvider { get; private set; } = null!;
	protected override void OnStartup(StartupEventArgs e)
	{
		base.OnStartup(e);

		var services = new ServiceCollection();
		services
			.AddStores()
			.AddServices()
			.AddConnectedServices()
			.AddCommands()
			.AddViewModels()
			.AddTransient<MainWindow>(provider =>
			{
				var viewModel = provider.GetRequiredService<MainViewModel>();
				viewModel.ContentViewModel = provider.GetRequiredService<LoginViewModel>();
				return new()
				{
					DataContext = viewModel,
				};
			});

		ServiceProvider = services.BuildServiceProvider();
		var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();

		mainWindow.Show();
	}
}
