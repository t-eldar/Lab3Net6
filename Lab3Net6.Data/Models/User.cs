using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3Net6.Data.Models;

public sealed class User
{
	public int Id { get; set; }
	public string Username { get; set; } = null!; 
	public string Password { get; set; } = null!;
}
