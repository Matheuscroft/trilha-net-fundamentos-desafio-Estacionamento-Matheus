namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

      
        private List<string> veiculos = new List<string>();

        public Estacionamento()
        {

        }

        public void EscolherValorInicial()
        {
            Console.WriteLine("\nBoas vindas ao sistema de estacionamento!\n" +
                  "Digite o preço inicial:");

            try
            {
                precoInicial = Convert.ToDecimal(Console.ReadLine());
            } catch (Exception ex)
            {
                Console.WriteLine($"\nÉ pra digitar um valor, não uma letra! {ex.Message}\n");
                EscolherValorInicial();
            }   
        }

        public void EscolherValorPorHora()
        {
            Console.WriteLine("\nAgora digite o preço por hora:");

            try
            {
                precoPorHora = Convert.ToDecimal(Console.ReadLine());

            } catch (Exception ex)
            {
                Console.WriteLine($"\nÉ pra digitar um valor, não uma letra! {ex.Message}\n");
                EscolherValorPorHora();
            }   
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            bool repetido = false;
            Console.WriteLine("\nDigite a placa do veículo para estacionar:");
            string placaCarro = Convert.ToString(Console.ReadLine());

            if(veiculos.Count == 0)
            {
                veiculos.Add(placaCarro);
                Console.WriteLine($"\nVeículo adicionado: {placaCarro}\n");
            }
            else
            {
                foreach(string veiculo in veiculos)
                {
                    if(veiculo == placaCarro)
                    {
                        repetido = true;
                        break;
                    }
                   
                }

                if (!repetido) 
                {
				    veiculos.Add(placaCarro);
                    Console.WriteLine($"\nVeículo adicionado: {placaCarro}\n");
			    }

			    else 
                {
				    Console.WriteLine("\nJá existe um veículo com essa placa!\n");
			    }
            }
            
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("\nDigite a placa do veículo para remover:\n");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Convert.ToString(Console.ReadLine());

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("\nDigite a quantidade de horas que o veículo permaneceu estacionado:\n");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = Convert.ToInt32(Console.ReadLine());
                
                decimal valorTotal = precoInicial + precoPorHora * horas; 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);

                Console.WriteLine($"\nO veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}\n");
            }
            else
            {
                Console.WriteLine("\nDesculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente\n");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("\nOs veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach(string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("\nNão há veículos estacionados.\n");
            }
        }
    }
}
