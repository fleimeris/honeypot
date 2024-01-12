using System.ComponentModel.DataAnnotations;

namespace App.Context.Models;

public class Login
{
    [Key]
    public required Guid Id { get; set; }

    public string? Username { get; set; }
    public string? Password { get; set; }
}