using System.ComponentModel.DataAnnotations;

namespace Microsoft.bigPotatoWeb.Web.ViewModels.Manage;

public class IndexViewModel
{
    [Display(Name = "Usuário")]
    public string? Username { get; set; }

    public bool IsEmailConfirmed { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "E-mail")]
    public string Email { get; set; }

    [Phone]
    [Display(Name = "Núm. Telefone")]
    public string PhoneNumber { get; set; }

    public string? StatusMessage { get; set; }
}
