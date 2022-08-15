using bytebank;
using bytebank.Titular;

Console.WriteLine("Boas Vindas ao seu Banco, ByteBank!");

//ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "Erick Pedrosa";
//conta1.conta = "10123-x";
//conta1.numeroAgencia = 23;
//conta1.nomeAgencia = "Agência Central";
//conta1.saldo = 93020.59;

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "Amanda Nogueira";
//conta2.conta = "11006-X";
//conta2.numeroAgencia = 23;
//conta2.nomeAgencia = "Agência Central";
//conta2.saldo = 100;


//Cliente cliente = new Cliente();

//cliente.nome = "André Silva";
//cliente.cpf = "123654987-00";
//cliente.profissao = "Programador C#";

//ContaCorrente conta3 = new ContaCorrente();

//conta3.titular = new Cliente();
//conta3.conta = "2583691-X";
//conta3.numeroAgencia = 35;
//conta3.nomeAgencia = "Agência Central";

//Console.WriteLine(cliente.nome);
//Console.WriteLine(conta3.titular.nome);


//ContaCorrente conta4 = new ContaCorrente(65, "36985201-X");

//conta4.Saldo = 50;
//conta4.Saldo = -750;

//Console.WriteLine("Saldo: " + conta4.Saldo);

ContaCorrente conta5 = new ContaCorrente(65, "36985201-X");
ContaCorrente conta6 = new ContaCorrente(77, "83822495-X");

Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();
