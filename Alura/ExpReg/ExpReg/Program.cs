using System.Text.RegularExpressions;

/*
Console.Write("Informe um e-mail:  ");
var caracteres = Console.ReadLine();

bool ok = Regex.IsMatch(caracteres, "[a-zA-Z_0-9]+@[a-z]+(.com)(.br)?");
if (!ok)
{
    Console.WriteLine("O valor informado não é um e-mail válido.");
}
else
{
    Console.WriteLine("O valor informado é um e-mail válido.");
}*/


/*
Console.Write("Informe um cpf para validação: ");
var cpf = Console.ReadLine();

Regex regex = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", RegexOptions.IgnoreCase);
var combinou = regex.Match(cpf);
if (combinou.Success)
{
    Console.WriteLine("CPF no formato válido.");
}
else
{
    Console.WriteLine("CPF inválido.");
}
*/


Console.Write("Informe um url para validação: ");
var url = Console.ReadLine();


Regex regex = new Regex(@"(hhtp(s)?://)?(www.)?[a-zA-Z_0-9]+(.com)(.br)?", RegexOptions.IgnoreCase);

var combinou = regex.Match(url);
if (combinou.Success)
{
    Console.WriteLine("email no formato válido.");
}
else
{
    Console.WriteLine("email inválido.");
}