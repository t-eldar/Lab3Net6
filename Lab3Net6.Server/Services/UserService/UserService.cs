using Lab3Net6.Server.Context;
using Lab3Net6.Data.Models;

using CoreWCF;
using Microsoft.EntityFrameworkCore.Internal;

namespace Lab3Net6.Server.Services;

public sealed class UserService : IUserService
{
	private readonly ApplicationContext _applicationContext;
	private readonly IPasswordHasher _passwordHasher;

	public UserService()
	{
		_applicationContext = new ApplicationContext();
		_passwordHasher = new PasswordHasher();
	}
	public User? Register(string username, string password)
	{
		var user = _applicationContext.Users.FirstOrDefault(u => u.Username == username);
		if (user is not null)
		{
			throw new FaultException($"User with username {username} already exists");
		}
		var hashedPassword = _passwordHasher.HashPassword(password);
		user = new User
		{
			Username = username,
			Password = hashedPassword,
		};
		_applicationContext.Users.Add(user);
		_applicationContext.SaveChanges();
		var registered = _applicationContext.Users.FirstOrDefault(u => u.Username == username);
		return registered;
	}

	public User? LogIn(string username, string password)
	{
		var user = _applicationContext.Users.FirstOrDefault(u => u.Username == username);
		if (user is null)
		{
			throw new FaultException($"No user with username {username}");
		}
		if (!_passwordHasher.VerifyPassword(password, user.Password))
		{
			throw new FaultException($"Password is incorrect!");
		}
		return user;
	}
}
