using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public static class TestaBanco
    {

        public static void MainBanco()
        {

            /*
            Conta c = new Conta();
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();
            AtualizadorDeContas atualizador = new AtualizadorDeContas(0.01);


            c.Depositar(1000);
            cc.Depositar(1000);
            cp.Depositar(1000);

            //c.Atualiza(0.01);
            //cc.Atualiza(0.01);
            //cp.Atualiza(0.01);

            atualizador.Roda(c);
            atualizador.Roda(cc);
            atualizador.Roda(cp);

            Console.WriteLine(c.Saldo);
            Console.WriteLine(cc.Saldo);
            Console.WriteLine(cp.Saldo);
            Console.WriteLine(atualizador.SaldoTotal);
            */
            AtualizadorDeContas atualizador = new AtualizadorDeContas(0.01);


            ContaCorrente cc = new ContaCorrente();
            ContaCorrente cc2 = new ContaCorrente();
            ContaCorrente cc3 = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();
            ContaPoupanca cp2 = new ContaPoupanca();
            ContaPoupanca cp3 = new ContaPoupanca();

            Banco banco = new Banco();

            cc.Depositar(1000);
            cp.Depositar(1000);

            cc2.Depositar(2000);
            cp2.Depositar(2000);

            cc3.Depositar(3000);
            cp3.Depositar(3000);

            banco.Adicionar(cc);
            banco.Adicionar(cc2);
            banco.Adicionar(cc3);

            banco.Adicionar(cp);
            banco.Adicionar(cp2);
            banco.Adicionar(cp3);

            //Conta conta5 = banco.RetornaConta(5);
            //Console.WriteLine(conta5.Saldo);
            //Console.WriteLine(banco.TotalDeContas());

            foreach (Conta conta in banco.Contas)
            {
                atualizador.Roda(conta);

            }
            Console.WriteLine($"Saldo total: R${atualizador.SaldoTotal}");


        }

    }
}
