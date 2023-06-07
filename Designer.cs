using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000) // Como o salário base de um designer é 3000 esse valor já foi passado 
        {

        }

        //Método de bonificação dos funcionários
        public override double GetBonificacao()
        {
            return this.Salario * 0.17;

        }

        //Método de aumetno salarial

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}