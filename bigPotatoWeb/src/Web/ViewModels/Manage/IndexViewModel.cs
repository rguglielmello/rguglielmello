using System.ComponentModel.DataAnnotations;

namespace Microsoft.bigPotatoWeb.Web.ViewModels.Manage;

public class IndexViewModel
{
    public string? Username { get; set; }

    public bool IsEmailConfirmed { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    [Display(Name = "Número de telefone")]
    public string PhoneNumber { get; set; }

    public string? StatusMessage { get; set; }
}
