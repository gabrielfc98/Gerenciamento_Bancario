using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        //Método de bonificação dos funcionários
        public override double GetBonificacao()
        {
            return this.Salario * 0.2;

        }

        //Método construtor de objeto diretor
        public Auxiliar(string cpf) : base(cpf, 2000) // Como o saário base de um auxiliar é 2000 esse valor já foi passado 
        {

        }

        //Método para aumento de salário do diretor
        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}
