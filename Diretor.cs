using ByteBank_ADM.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {

        //Método de bonificação dos funcionários
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;

        }

        //Método construtor de objeto diretor
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        //Método para aumento de salário do diretor
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

    }

}