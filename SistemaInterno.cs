using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Sistema
{
    public class SistemaInterno
    {
        public bool Logar(FuncionarioAutenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticar = funcionario.Autenticar(senha, login);
            if (usuarioAutenticar)
            {
                Console.WriteLine($"{funcionario.Nome},Bem Vindo ao Sitema ByteBank!\n");
                return true;
            }
            else
            {
                Console.WriteLine($"{funcionario.Nome},O login falhou. Verifique se o login e a senha informados estão corretos\n");
                return false;
            }
        }

        public bool Logar(ParceiroComercial funcionario, string senha, string login)
        {
            bool usuarioAutenticar = funcionario.Autenticar(senha, login);
            if (usuarioAutenticar)
            {
                Console.WriteLine($"Bem Vindo ao Sitema ByteBank!\n");
                return true;
            }
            else
            {
                Console.WriteLine($"O login falhou. Verifique se o login e a senha informados estão corretos\n");
                return false;
            }
        }
    }
}