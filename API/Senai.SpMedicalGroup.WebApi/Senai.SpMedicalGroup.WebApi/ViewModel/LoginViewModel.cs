﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SpMedicalGroup.WebApi.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email deve ser informado.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha deve ser informada")]
        [DataType(DataType.Password)]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Senha deve possuir pelo menos 4 caracteres.")]
        public string Senha { get; set; }
    }
}
