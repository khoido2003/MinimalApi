using System.ComponentModel.DataAnnotations;

namespace MinimalAPI.Models
{
  public class Command
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public string? HowTo { get; set; }

    [Required]
    [MaxLength(5)]
    public String? Platform { get; set; }

    [Required]
    public String? CommandLine { get; set; }

  }
}