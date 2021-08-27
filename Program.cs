using System; 

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            ConverteConta<ContaInvestimento, ContaCorrente>(new ContaInvestimento(20));
            
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
