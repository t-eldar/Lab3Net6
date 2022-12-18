using Lab3Net6.Client.Commands;
using Lab3Net6.Client.Services;
using Lab3Net6.Client.Stores;
using Lab3Net6.Client.ViewModels;

using Microsoft.Extensions.DependencyInjection;

using ServiceReference1;

using ServiceReference2;

namespace Lab3Net6.Client;
public static class ServiceConfigurationExtension
{
	public static IServiceCollection AddViewModels(this IServiceCollection services)
		=> services
			.AddTransient<LoginViewModel>()
			.AddTransient<RegisterViewModel>()
			.AddSingleton<MainViewModel>(provider => new(
				() => provider.GetRequiredService<LoginViewModel>(),
				() => provider.GetRequiredService<RegisterViewModel>()));
	public static IServiceCollection AddConnectedServices(this IServiceCollection services)
		=> services
			.AddTransient<UserServiceClient>(provider =>
			{
				var client = new UserServiceClient(UserServiceClient.EndpointConfiguration.BasicHttpBinding_IUserService);
				return client;
			})
			.AddTransient<TodoServiceClient>(provider =>
			{
				var client = new TodoServiceClient(TodoServiceClient.EndpointConfiguration.BasicHttpBinding_ITodoService);
				return client;
			});
	public static IServiceCollection AddServices(this IServiceCollection services)
		=> services
			.AddTransient<IMapper, Mapper>()
			.AddTransient<IAuthenticationService, AuthenticationService>();
	public static IServiceCollection AddStores(this IServiceCollection services)
		=> services
			.AddSingleton<NavigationStore>()
			.AddSingleton<AccountStore>();
	public static IServiceCollection AddCommands(this IServiceCollection services)
		=> services
			.AddTransient<LoginAsyncCommand>()
			.AddTransient<RegisterAsyncCommand>()
			.AddTransient<NavigateRegisterCommand>();
}

