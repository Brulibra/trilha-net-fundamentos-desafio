using System.Numerics;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string novaPlaca = Console.ReadLine();

            if (novaPlaca == "")
            {
                Console.WriteLine("Por favor, insira a placa do carro que deseja estacionar \n Retornando ao Menu Inicual\n");
            }
            else if (novaPlaca.Length != 8)
            {
                Console.WriteLine("O formato da placa deve ser ###-#### \n Retornando ao Menu Inicual\n");
            }
            else
            {
                Console.WriteLine("Carro estacionado");
                veiculos.Add(novaPlaca);
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:\n");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:\n");

                int horas = 0;
                decimal valorTotal = 0;

                string horasEstacionadas = Console.ReadLine();

                horas = Convert.ToInt32(horasEstacionadas);

                valorTotal = precoInicial + horas * precoPorHora;

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n");
                int contagemVeículos = 1;
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"{contagemVeículos}  {veiculo}");
                    contagemVeículos++;
                }

                Console.WriteLine($"\nTotal de veículos estacionados {veiculos.Count}");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
