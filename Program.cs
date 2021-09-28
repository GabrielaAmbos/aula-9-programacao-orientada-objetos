using System;
using aula_9_programacao_orientada_objetos.conta;
using aula_9_programacao_orientada_objetos.geradorExtrato;

namespace aula_9_programacao_orientada_objetos
{
    class Program
    {
        static ContaCorrente contaCorrente = new ContaCorrente();
        static ContaPoupanca contaPoupanca = new ContaPoupanca();
        static GeradorDeExtratos geradorDeExtratos = new GeradorDeExtratos();
        static void Main(string[] args)
        {
           Inicio();
        }

        private static void Inicio() {
            int opcao = 0;
            do{
                Console.WriteLine("Escolha uma opção a seguir: \n[1]-Conta Corrente; \n[2]-Conta Poupança \n[3]-Extratos \n[00]-Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch(opcao) {
            case 1: 
                ContaCorrente();
                break;
            case 2:
                ContaPoupanca();
                break;
            case 3:
                GerarExtratoContaCorrente();
                GerarExtratoContaPoupanca();
                break;        
            case 00:
                Sair();
                break;
            default:
                Console.WriteLine("Opção inválida!!!!");
                break;
                }
            }  while(opcao != 00);
        }


        private static void ContaCorrente() {
            int opcao = 0;
            do{
                Console.WriteLine("Escolha uma opção a seguir: \n[1]-Depositar; \n[2]-Sacar \n[000]-Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch(opcao) {
            case 1: 
                ContaCorrenteDepositar();
                break;
            case 2:
                ContaCorrenteSacar();
                break;
            case 000:
                Sair();
                break;
            default:
                Console.WriteLine("Opção inválida!!!!");
                break;
                }
            }  while(opcao != 000);
        }

        private static void ContaPoupanca() {
            int opcao = 0;
            do{
                Console.WriteLine("Escolha uma opção a seguir: \n[1]-Depositar; \n[2]-Sacar \n[000]-Sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch(opcao) {
            case 1: 
                ContaPoupancaDepositar();
                break;
            case 2:
                ContaPoupancaSacar();
                break;     
            case 000:
                Sair();
                break;
            default:
                Console.WriteLine("Opção inválida!!!!");
                break;
                }
            }  while(opcao != 000);
        }

        private static void ContaCorrenteDepositar() {
            Console.WriteLine("Informe o valor que você deseja depositar:");
            double valor = Convert.ToDouble(Console.ReadLine());
            contaCorrente.Depositar(valor);
        }

        private static void ContaCorrenteSacar() {
            Console.WriteLine("Informe o valor que você deseja sacar:");
            double valor = Convert.ToDouble(Console.ReadLine());
            contaCorrente.Sacar(valor);
        }

         private static void ContaPoupancaDepositar() {
            Console.WriteLine("Informe o valor que você deseja depositar:");
            double valor = Convert.ToDouble(Console.ReadLine());
            contaPoupanca.Depositar(valor);
        }

        private static void ContaPoupancaSacar() {
            Console.WriteLine("Informe o valor que você deseja sacar:");
            double valor = Convert.ToDouble(Console.ReadLine());
            contaPoupanca.Sacar(valor);
        }

        private static void GerarExtratoContaCorrente() {
            geradorDeExtratos.GerarExtrato(contaCorrente);
        }

        private static void GerarExtratoContaPoupanca() {
            geradorDeExtratos.GerarExtrato(contaPoupanca);
        }

        private static void Sair() {
            Console.WriteLine("Saindo...");
        }  
    }
}
