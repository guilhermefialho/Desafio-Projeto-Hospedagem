namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


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
                throw new InvalidOperationException("Capacidade da suite insuficiente para o número de hóspedes.");
             }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
             if (Hospedes != null)
                     {
                return Hospedes.Count;
                     }
            return 0; // Retorna 0 se não houver hóspedes na reserva.
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * Suite.ValorDiaria; // Cálculo: DiasReservados X Suite.ValorDiaria
            
           
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
           
            if (true)
            {
                 valor *= 0.9m;
            }

            return valor;
        }
    }
}