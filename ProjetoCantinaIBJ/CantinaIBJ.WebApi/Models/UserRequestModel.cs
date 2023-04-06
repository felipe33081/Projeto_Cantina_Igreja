﻿using System.ComponentModel.DataAnnotations;
using MvcContrib.UI.InputBuilder.Attributes;
using Swashbuckle.AspNetCore.Swagger;

namespace CantinaIBJ.WebApi.Models;

public class UserRequestModel
{
    /// <summary>
    /// Login do usuário
    /// </summary>
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [RegularExpression(@"^[a-zA-Z0-9]{1,50}$",
        ErrorMessage = "O nome de usuário deve ter no máximo 50 caracteres e só pode conter letras, números.")]
    public string Username { get; set; }

    /// <summary>
    /// Senha do usuário
    /// </summary>
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$",
        ErrorMessage = "A senha deve ter pelo menos 8 caracteres, uma letra maiúscula, uma letra minúscula, um número e um caractere especial.")]
    [Example("Senha@123")]
    public string Password { get; set; }
}