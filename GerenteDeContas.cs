using ByteBank_ADM.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {

        public GerenteDeContas(string cpf) : base(cpf, 4000)// Como o salário base de um Gerente é 4000 esse valor já foi passado 
        {

        }

        //Método de bonificação dos funcionários
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;

        }

        //Método para aumentar salário:
        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
