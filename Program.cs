﻿using System; 

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrente(20);

            Console.WriteLine(ConverteConta<ContaInvestimento, ContaCorrente>(new ContaInvestimento(20)));
            // Console.WriteLine((new ContaCorrente())new Conta());
            
        }

    public static A ConverteConta<T, A>(T conta) where T : Conta where A : Conta
        {
           A novaConta = Activator.CreateInstance<A>();
           
           novaConta.SetAgencia(conta.Agencia);
           novaConta.SetNumero(conta.Numero);
           novaConta.Depositar(conta.Saldo);

           return novaConta;
    
        }
    }
}
