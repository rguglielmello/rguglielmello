using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Microsoft.bigPotatoWeb.Web.ViewModels.Manage;

public class EnableAuthenticatorViewModel
{
    [Required]
    [StringLength(7, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
    [DataType(DataType.Text)]
    [Display(Name = "Código de verificação")]
    public string Code { get; set; }

    [BindNever]
    public string SharedKey { get; set; }

    [BindNever]
    public string AuthenticatorUri { get; set; }
}
