namespace aula_9_programacao_orientada_objetos.conta
{
    public interface Conta
    {
        void Depositar(double valor) {}

        void Sacar(double valor) {}

        double GetSaldo() {}
    }
}