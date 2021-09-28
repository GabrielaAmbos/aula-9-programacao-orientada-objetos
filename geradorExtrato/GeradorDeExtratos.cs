using System;
using aula_9_programacao_orientada_objetos.conta;

namespace aula_9_programacao_orientada_objetos.geradorExtrato
{
    public class GeradorDeExtratos : Conta
    {
        public void GerarExtrato(Conta c) {
            Console.WriteLine("Saldo disponível: " + c.GetSaldo());
        }
    }
}