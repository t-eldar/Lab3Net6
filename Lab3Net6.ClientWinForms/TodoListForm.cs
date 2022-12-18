using System.ComponentModel;

using Lab3Net6.ClientWinForms.Utilities;

using ServiceReference1;

using ServiceReference2;

namespace Lab3Net6.ClientWinForms;
public partial class TodoListForm : Form
{
	private readonly TodoServiceClient _todoServiceClient;
	private User _user;
	private BindingList<Todo>? _todos;

	public TodoListForm(User user)
	{
		InitializeComponent();
		_todoServiceClient = new TodoServiceClient(
			TodoServiceClient.EndpointConfiguration.BasicHttpBinding_ITodoService,
			"http://localhost:5000/TodoService/basichttp");
		_user = user;
	}
	private async void TodoListForm_Load(object sender, EventArgs e)
	{
		var todosArray = await ExceptionCatcher.CatchAsync(_todoServiceClient.GetTodosAsync(_user.Id));
		if (todosArray is null)
		{
			return;
		}
		_todos = new BindingList<Todo>(todosArray.ToList());
		todosDataGridView.DataSource = _todos;
		todosDataGridView.Columns[0].HeaderText = "Описание";
		todosDataGridView.Columns[2].HeaderText = "Сделано";
		todosDataGridView.Columns["Id"].Visible = false;
		todosDataGridView.Columns["UserId"].Visible = false;
	}

	private async void todosDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		if (e.ColumnIndex == -1 || e.RowIndex == -1)
		{
			return;
		}
		if ((int)todosDataGridView["Id", e.RowIndex].Value == 0)
		{
			var todo = new Todo
			{
				UserId = _user.Id,
				Description = (string)todosDataGridView["Description", e.RowIndex].Value,
				IsDone = (bool)todosDataGridView["IsDone", e.RowIndex].Value,
			};
			await ExceptionCatcher.CatchAsync(_todoServiceClient.CreateTodoAsync(todo));
			return;
		}
		var id = (int)todosDataGridView["Id", e.RowIndex].Value;
		var isDone = (bool)todosDataGridView["IsDone", e.RowIndex].Value;
		var description = (string)todosDataGridView["Description", e.RowIndex].Value;
		var task = _todoServiceClient.UpdateTodoAsync(id, new Todo
		{
			Description = description,
			IsDone = isDone,
		});
		await ExceptionCatcher.CatchAsync(ExceptionCatcher.CatchAsync(task));
	}

	private async void deleteButton_Click(object sender, EventArgs e)
	{
		var selected = todosDataGridView.SelectedRows[0];
		var id = (int)todosDataGridView["Id", selected.Index].Value;
		await ExceptionCatcher.CatchAsync(_todoServiceClient.DeleteTodoAsync(id));
		_todos?.RemoveAt(selected.Index);
	}
}
