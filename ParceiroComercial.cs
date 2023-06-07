﻿using ByteBank_ADM.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public string Login { get; set; }

        public bool Autenticar(string senha, string login)
        {
            return (this.Senha == senha && this.Login == login);
        }

    }
}