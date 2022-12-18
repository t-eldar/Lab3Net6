using UserModel = Lab3Net6.Data.Models.User;
using TodoModel = Lab3Net6.Data.Models.Todo;

using UserReponse = ServiceReference1.User;
using TodoResponse = ServiceReference2.Todo;

namespace Lab3Net6.Client.Services;
public interface IMapper
{
	UserModel MapUser(UserReponse user);
	IEnumerable<UserModel> MapUsers(IEnumerable<UserReponse> users);
	TodoModel MapTodo(TodoResponse response);
	IEnumerable<TodoModel> MapUsers(IEnumerable<TodoResponse> todos);

}
