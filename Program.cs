using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.Sistema;
using ByteBank_ADM.Utilitario;
using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
#region
//            Funcionario pedro = new Funcionario("123.456.789 - 01", 2000);
//            pedro.Nome = "Pedro Martins";


//            Console.WriteLine($@"
//Nome do funcionário: {pedro.Nome}
//CPF do funcionário: {pedro.Cpf}
//Salário do funcionário: {pedro.Salario.ToString("c")}
//Bonificação do Funcionário: {pedro.GetBonificacao().ToString("c")}
//Salário com a Bonificação: {(pedro.Salario + pedro.GetBonificacao()).ToString("c")}");

//            Diretor roberta = new Diretor("987.654.321-10");
//            roberta.Nome = "Roberta Miranda";

//            Console.WriteLine($@"
//Nome do funcionário: {roberta.Nome}
//CPF do funcionário: {roberta.Cpf}
//Salário do funcionário: {roberta.Salario.ToString("c")}
//Bonificação do Funcionário: {roberta.GetBonificacao().ToString("c")}
//Salário com a Bonificação: {(roberta.Salario + roberta.GetBonificacao()).ToString("c")}");

//            Console.WriteLine("");

//            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//            gerenciador.Registrar(pedro);
//            gerenciador.Registrar(roberta);

//            Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
//            Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

//            pedro.AumentarSalario();
//            roberta.AumentarSalario();

//            Console.WriteLine($@"
//Novo salário Pedro: {pedro.Salario.ToString("c")}
//Novo salário Roberta:{roberta.Salario.ToString("c")}");
#endregion
//CalcularBonificacao();

#region
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("12345678901");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("98765432189");
    paula.Nome = "Paula Fernandes";

    Auxiliar igor = new Auxiliar("45678932101");
    igor.Nome = "Igor Menezes";

    GerenteDeContas camila = new GerenteDeContas("98765412354");
    camila.Nome = "Camila Freire";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine($"Total de Bonificação: {gerenciador.TotalDeBonificacao}");
    #endregion
}
UsarSistema();
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("1234987654");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";
    ingrid.Login = ingrid.Nome;

    GerenteDeContas ursula = new GerenteDeContas("65478912365");
    ursula.Nome = "Ursula Bianchi";
    ursula.Senha = "321";
    ursula.Login = ursula.Nome;

    sistema.Logar(ingrid, "123", "Ingrid Novaes");
    sistema.Logar(ursula, "123", "Ursinha carinhosa");

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "789";
    caio.Login = "Caio Menezes";

    sistema.Logar(caio, "789", "Caio Menezes");
}
