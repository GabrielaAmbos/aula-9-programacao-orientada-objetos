using System;
using aula_9_programacao_orientada_objetos.conta;

namespace aula_9_programacao_orientada_objetos.conta
{
    public class ContaCorrente : Conta 
    {
        public double Saldo {get; private set;} 

        public double Tarifa {get; private set;}

        public void Depositar(double valor) {
            if(valor <= 0) { 
                Console.WriteLine("Você não pode depositar um valor negativo!!!");
            } else {
                Saldo += valor;
            }
        }

        public void Sacar(double valor) {
            Tarifa = 1.50; 
             if(Saldo < valor) {
                Console.WriteLine("Você nao tem saldo suficiente para sacar!");
            } else if (valor <= 0) {
                Console.WriteLine("Você não pode informar um valor negativo!!!");
            } else {
               Saldo -= valor - Tarifa;
            }
        }

        double GetSaldo() {
            return Saldo;
        }
    }
}