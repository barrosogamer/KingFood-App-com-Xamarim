﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kingfood.Models
{
    public class Usuario
    {
        public string nome { get; set; }
        public string email { get; set; }
        public Usuario()
        {
            nome = "Padrão";
            email = "Padrão@gmail.com";
        }
    }
}
