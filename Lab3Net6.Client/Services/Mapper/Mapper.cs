namespace Lab3Net6.Client.Services;
public class Mapper : IMapper
{
	public Data.Models.Todo MapTodo(ServiceReference2.Todo response)
		=> new()
		{
			Id = response.Id,
			Description = response.Description,
			IsDone = response.IsDone,
			UserId = response.UserId,
		};
	public Data.Models.User MapUser(ServiceReference1.User user)
		=> new()
		{
			Id = user.Id,
			Username = user.Username,
			Password = user.Password,
		};

	public IEnumerable<Data.Models.User> MapUsers(IEnumerable<ServiceReference1.User> users) 
		=> users.Select(u => MapUser(u));
	public IEnumerable<Data.Models.Todo> MapUsers(IEnumerable<ServiceReference2.Todo> todos) 
		=> todos.Select(t => MapTodo(t));
}
