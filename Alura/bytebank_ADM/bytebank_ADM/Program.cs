using bytebank_ADM.Funcionarios;
using bytebank_ADM.Utilitarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.ParceriaComercial;


Console.WriteLine("Boas Vindas, ao ByteBanck Administração");

UsarSistema();


void CalcularBonificacao()
{

    GerenciadorDeBonificacoes gerenciador = new GerenciadorDeBonificacoes();

    Designer pedro = new Designer("123456789-00");
    pedro.Nome = "Pedro";

    Desenvolvedor igor = new Desenvolvedor("597412386-11");
    igor.Nome = "Igor";

    Diretor paula = new Diretor("987654321-00");
    paula.Nome = "Paula";

    Auxiliar andre = new Auxiliar("159753264-88");
    andre.Nome = "André";

    GerenteDeContas camila = new GerenteDeContas("795136428-55");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(andre);
    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);


    Console.WriteLine($"Total de bonificações: {gerenciador.getBonificacao()} ");
    Console.WriteLine($"Total de funcionários: {Funcionario.totalDeFuncionarios}");

}

/*
andre.aumentarSalario();
Console.WriteLine($"\nNovo salário do {andre.Nome}: {andre.Salario}");
pedro.aumentarSalario();
Console.WriteLine($"Novo salário do {pedro.Nome}: {pedro.Salario}\n");
*/

void imprimeFuncionario(Funcionario funcionario)
{
    Console.WriteLine($"Nome: {funcionario.Nome} ");
    Console.WriteLine($"CPF: {funcionario.Cpf} ");
    Console.WriteLine($"Salário: {funcionario.Salario} ");
    Console.WriteLine($"Bonificação: {funcionario.getBonificacao()} \n");
}


void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor roberta = new Diretor("123456789-00");
    roberta.Nome = "Roberta";
    roberta.Senha = "12345";

    GerenteDeContas amanda = new GerenteDeContas("987654321-00");
    amanda.Nome = "Amanda";
    amanda.Senha = "54321";

    //Designer pedro = new Designer("156324897-22");
    //pedro.Nome = "Pedro";
    //pedro.Senha = "88888";

    //sistema.Logar(pedro, "88888");

    ParceiroComercial joao = new ParceiroComercial();
    joao.Senha = "76890";


    sistema.Logar(roberta, "12345");
    sistema.Logar(amanda, "12345");
    sistema.Logar(joao  , "76890");



}
