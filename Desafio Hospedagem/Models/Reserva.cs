namespace DesafioHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // IMPLEMENTADO
            int capacidade = Suite.Capacidade;
            int quantidadeHospedes = hospedes.Count();
            if (capacidade >= quantidadeHospedes)
            {
                Hospedes = hospedes;
            }
            else
            {

                // IMPLEMENTADO
                throw new Exception("Capacidade da Suíte insuficiente para receber esse número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO
            int quantidadeHospedes = Hospedes.Count();
            return quantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // IMPLEMENTADO
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // IMPLEMENTADO
            decimal percentual = 0.1m;
            decimal desconto = valor * percentual;
            if (DiasReservados >= 10)
            {
                valor = valor - desconto;
            }

            return valor;
        }
    }
}