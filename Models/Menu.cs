using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Menu
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        private string nomePessoa;
        private string sobrenomePessoa;
        private string TipoSuite;
        private int Capacidade;
        private decimal ValorDiaria;
        List<Pessoa> hospedes = new();

        public void CadastrarHospedes()
        {

            string continuar;

            do
            {
                Console.WriteLine("Digite o nome do hospede: ");
                nomePessoa = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome do hospede: ");
                sobrenomePessoa = Console.ReadLine();
                Pessoa pessoa = new Pessoa(nomePessoa, sobrenomePessoa);
                hospedes.Add(pessoa);

                Console.WriteLine("Deseja cadastrar outro hóspede? (s/n)");
                continuar = Console.ReadLine();
            }

            while (continuar?.Trim().ToLower() == "s");
        }

        public void CadastrarSuite()
        {

            try
            {
                Console.WriteLine("Digite o tipo da suite: ");
                TipoSuite = Console.ReadLine();
                if (TipoSuite == null)
                {
                    throw new Exception();
                }

                Console.WriteLine("Digite a capacidade da suite: ");
                Capacidade = Convert.ToInt32(Console.ReadLine());

                if (Capacidade < hospedes.Count || Capacidade <= 1)
                {
                    throw new Exception();
                }

                Console.WriteLine("Digite o valor da diária: ");
                ValorDiaria = Convert.ToDecimal(Console.ReadLine());
                if (ValorDiaria <= 1)
                {
                    throw new Exception();
                }

                Suite suite = new Suite(tipoSuite: TipoSuite, capacidade: Capacidade, valorDiaria: ValorDiaria);
                Suite = suite;
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Erro ao cadastrar suite: {ex.Message}. Verifique se os dados inseridos são válidos e se a capacidade da suite comporta o número de hóspedes.");
            }
        }
        public void ApresentarSuite()
        {
            Console.WriteLine($"Tipo da Suite: {TipoSuite}\nCapacidade: {Capacidade}\nValor Diária: {ValorDiaria} ");
        }
        public void ApresentarQuantidadeHospedes()
        {
            Console.WriteLine($"Numero de hóspedes cadastrados é: {hospedes.Count}");
        }
        public decimal CalcularValorDiaria()
        {
            Console.WriteLine("Digite a quantidade de dias reservados: ");
            int DiasReservados = Convert.ToInt32(Console.ReadLine());
            decimal valor = DiasReservados * ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = valor - valor * 0.1M;
            }

            return valor;
        }

        public void ApresentarCalculoValorDiaria()
        {
            Console.WriteLine($"Valor total da estadia é: {CalcularValorDiaria():C}");
        }
    }   
}
