namespace DesafioProjetoHospedagem.Models
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
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("A quantidade de hospedes excede a capacidade permitida!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;
            
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            int diasReservados = DiasReservados;
            decimal valorDiaria = Suite.ValorDiaria;
            decimal valor = diasReservados * valorDiaria;
            
            if (diasReservados >= 10)
            {
                decimal desconto = 0.10M * (diasReservados * valorDiaria);
                valor = diasReservados * valorDiaria - desconto;
            }

            return valor;
        }
    }
}