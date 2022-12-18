using CoreWCF;

using Lab3Net6.Data.Models;

namespace Lab3Net6.Server.Services;

[ServiceContract]
public interface ITodoService
{

	[OperationContract]
	[FaultContract(typeof(string))]
	IEnumerable<Todo>? GetTodos(int userId);

	[OperationContract]
	[FaultContract(typeof(string))]
	void CreateTodo(Todo todo);

	[OperationContract]
	[FaultContract(typeof(string))]
	void DeleteTodo(int id);

	[OperationContract]
	[FaultContract(typeof(string))]
	void UpdateTodo(int id, Todo todo);
}
