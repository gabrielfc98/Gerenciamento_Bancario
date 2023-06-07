using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Sistema
{
    public interface IAutenticavel
    {

        //Criando um atributo senha para que o funcionário consiga logar no sistema
        public string Senha { get; set; }

        //Criando um atributo login para que o funcionário posso logar no sistema

        public string Login { get; set; }

        // Criando um método para verificar se a senha registrada é igual a senha cadastrada
        public bool Autenticar(string senha, string login);

    }
}
