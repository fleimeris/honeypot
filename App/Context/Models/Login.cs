using System.ComponentModel.DataAnnotations;

namespace App.Context.Models;

public class Login
{
    [Key]
    public required int Id { get; set; }

    public required string Username { get; set; }
    public required string Password { get; set; }
}