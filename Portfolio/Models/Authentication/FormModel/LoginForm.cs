﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models.Authentication.FormModel
{
    public class LoginForm
    {
        [Required]
        [Display(Name = "Имя пользователя")]
        public string UserName { get; set; } = null!;

        [Required]
        [DataType(DataType.Password), Display(Name = "Пароль")]
        public string Password { get; set; } = null!;

        [Display(Name = "Запомнить?")]
        public bool RememberMe { get; set; } = false;

        [ValidateNever]
        public string ReturnUrl { get; set; } = null!;
    }
}
