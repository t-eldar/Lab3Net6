using Lab3Net6.Server.Context;
using Lab3Net6.Data.Models;
using CoreWCF;

namespace Lab3Net6.Server.Services;

public sealed class TodoService : ITodoService
{
	private readonly ApplicationContext _applicationContext;
	public TodoService()
		=> _applicationContext = new ApplicationContext();
	public IEnumerable<Todo>? GetTodos(int userId)
	{
		var user = _applicationContext.Users.FirstOrDefault(u => u.Id == userId);

		if (user is null)
		{
			throw new FaultException($"There is no user with id = {userId}");
		}
		var todos = _applicationContext.Todos
			.Where(t => t.UserId == userId)
			.Select(t => t);
		return todos;
	}
	public void CreateTodo(Todo todo)
	{
		_applicationContext.Todos.Add(todo);
		_applicationContext.SaveChanges();
	}
	public void DeleteTodo(int id)
	{
		var todo = _applicationContext.Todos.FirstOrDefault(t => t.Id == id);
		if (todo is null)
		{
			throw new FaultException($"There is no todo with id = {id}");
		}
		_applicationContext.Todos.Remove(todo);
		_applicationContext.SaveChanges();
	}

	public void UpdateTodo(int id, Todo todo)
	{
		var entity = _applicationContext.Todos.FirstOrDefault(t => t.Id == id);
		if (entity is null)
		{
			throw new FaultException($"Entity with id = {id} does not exists");
		}
		entity.Description = todo.Description;
		entity.IsDone = todo.IsDone;
		_applicationContext.SaveChanges();
	}
}
