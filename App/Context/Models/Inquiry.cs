using System.ComponentModel.DataAnnotations;

namespace App.Context.Models;

public class Inquiry
{
    [Key]
    public required Guid Id { get; set; }
    
    public required string UserAgent { get; set; } 
    public required string Referer { get; set; }
    public required string Host { get; set; }
    public required string HttpMethod { get; set; }
    public required string Endpoint { get; set; }
    public string? Ip { get; set; }
    public required string Cookies { get; set; }
    public required string Query { get; set; }
    public string? Body { get; set; }
    public DateTime DateCaptured { get; set; }
}