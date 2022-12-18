using CoreWCF;
using CoreWCF.Configuration;
using CoreWCF.Description;

using Lab3Net6.Server.Services;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Default");

builder.WebHost.ConfigureKestrel((context, options) =>
{
	options.AllowSynchronousIO = true;
});
builder.Services
	.AddServiceModelServices()
	.AddServiceModelMetadata()
	.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();


var app = builder.Build();
var todoUrl = builder.Configuration["ServiceUrls:TodoService"];
var userUrl = builder.Configuration["ServiceUrls:UserService"];

app.UseServiceModel(builder =>
{
	builder
		.AddService<TodoService>(options =>
		{
			options.DebugBehavior.IncludeExceptionDetailInFaults = true;
		})
		.AddServiceEndpoint<TodoService, ITodoService>(new BasicHttpBinding(), todoUrl)
		.AddService<UserService>(options =>
		{
			options.DebugBehavior.IncludeExceptionDetailInFaults = true;
		})
		.AddServiceEndpoint<UserService, IUserService>(new BasicHttpBinding(), userUrl);
});
var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
serviceMetadataBehavior.HttpGetEnabled = true;

app.Run();
