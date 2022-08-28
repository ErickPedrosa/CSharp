using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;


Console.WriteLine("Boas Vindas, ao ByteBanck Administração");

GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();

Funcionario pedro = new Funcionario();

pedro.Nome = "Pedro";
pedro.Cpf = "123456789-00";
pedro.Salario = 2000;

Console.WriteLine($"Nome: {pedro.Nome} ");
Console.WriteLine($"CPF: {pedro.Cpf} ");
Console.WriteLine($"Salário: {pedro.Salario} ");
Console.WriteLine($"Bonificação: {pedro.getBonificacao()} \n");

Diretor paula = new Diretor();

paula.Nome = "Paula";
paula.Cpf = "987654321-00";
paula.Salario = 5000;

Console.WriteLine($"Nome: {paula.Nome} ");
Console.WriteLine($"CPF: {paula.Cpf} ");
Console.WriteLine($"Salário: {paula.Salario} ");
Console.WriteLine($"Bonificação: {paula.getBonificacao()} \n");


gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine($"Total de bonificações: {gerenciador.getBonificacao()} ");

