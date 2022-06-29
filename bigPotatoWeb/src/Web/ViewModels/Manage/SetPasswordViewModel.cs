﻿using System.ComponentModel.DataAnnotations;

namespace Microsoft.bigPotatoWeb.Web.ViewModels.Manage;

public class SetPasswordViewModel
{
    [Required]
    [StringLength(100, ErrorMessage = "O {0} deve ter pelo menos {2} e no máximo {1} caracteres.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Nova senha")]
    public string NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Display(Name = "Confirme a nova senha")]
    [Compare("NewPassword", ErrorMessage = "A nova senha e a senha de confirmação não coincidem.")]
    public string ConfirmPassword { get; set; }

    public string StatusMessage { get; set; }
}
