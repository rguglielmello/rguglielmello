using System.ComponentModel.DataAnnotations;

namespace Microsoft.bigPotatoWeb.Web.ViewModels.Account;

public class LoginWith2faViewModel
{
    [Required]
    [StringLength(7, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
    [DataType(DataType.Text)]
    [Display(Name = "Authenticator code")]
    public string TwoFactorCode { get; set; }

    [Display(Name = "Lembrar nesta máquina")]
    public bool RememberMachine { get; set; }

    public bool RememberMe { get; set; }
}
