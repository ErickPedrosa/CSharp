using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class TestaTributavel
    {
        public static void Teste()
        {
            ContaCorrente c = new ContaCorrente();
            ContaCorrente c2 = new ContaCorrente();
            SeguroDeVida s = new SeguroDeVida();

            c.Depositar(1000000);
            c2.Depositar(10000);

            Console.WriteLine($"\nSaldo da Conta Corrente: R${c.Saldo}");
            Console.WriteLine($"Tributo a pagar: R${c.CalcularTributos()}");

            Console.WriteLine($"Tributo a pagar pelo seguro de vida: R${s.CalcularTributos()}");

            Console.WriteLine($"Saldo da Conta Corrente 2: R${c.Saldo}");
            Console.WriteLine($"Tributo a pagar: R${c.CalcularTributos()}");

            ITributavel[] vetTributaveis = new ITributavel[3];

            vetTributaveis[0] = c;
            vetTributaveis[1] = s;
            vetTributaveis[2] = c2;


            GerenciadorDeImpostoDeRenda impostoDeRenda = new GerenciadorDeImpostoDeRenda(vetTributaveis);

            impostoDeRenda.ImprimeTotalTributos();
        }
    }
}
