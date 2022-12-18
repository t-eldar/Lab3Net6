using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3Net6.Data.Models;

public sealed class Todo
{
	public int Id { get; set; }
	public string Description { get; set; } = null!;
	public bool IsDone { get; set; }
	public int UserId { get; set; }
}
