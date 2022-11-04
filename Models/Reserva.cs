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
            
            if (Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            } 
            else
            {
              
               throw new Exception("Quantidade de Hospede não pode ser maior que a capacidade da Suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor  = DiasReservados * Suite.ValorDiaria;;
            
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
             
            if (DiasReservados >= 10)
            {
                valor =  valor * 0.90M;
            }

            return valor;
        }
    }
}