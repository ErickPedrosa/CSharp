using bytebank.Titular;

namespace bytebank
{
    
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string NomeAgencia { get; set; }
        private string _conta;
        private int _numeroAgencia;
        private double saldo;

        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }

        }

        public int NumeroAgencia {
            get
            {
                return _numeroAgencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                else
                {
                    _numeroAgencia = value;
                }
            }
                
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }


        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else if(valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            saldo += valor;
            
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        

        public ContaCorrente(int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }

    }

}

