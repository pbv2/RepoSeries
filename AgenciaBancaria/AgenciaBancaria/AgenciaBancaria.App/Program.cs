using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "12345678", "Recife", "PE");
                Cliente cliente = new Cliente("Pedro", "123456789", "12345678", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao + ": "+ conta.NumeroConta + "-" + conta.DigitoVerificador);
                conta.Abrir("abc123456789");
                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);
                conta.Sacar(10, "abc123456789");
                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
              
        }
    }
}
