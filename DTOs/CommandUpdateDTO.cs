using System.ComponentModel.DataAnnotations;

namespace MinimalAPI.DTOs
{
  public class CommandUpdateDTO
  {
    [Required]
    public string? HowTo { get; set; }

    [Required]
    [MaxLength(5)]
    public String? Platform { get; set; }

    [Required]
    public String? CommandLine { get; set; }
  }
}
