﻿using System.ComponentModel.DataAnnotations;

namespace Microsoft.bigPotatoWeb.Web.ViewModels.Account;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Display(Name = "Lembrar neste computador?")]
    public bool RememberMe { get; set; }
}
