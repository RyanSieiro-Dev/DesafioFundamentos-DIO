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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            string placa = Console.ReadLine();

            if (placa.Length == 8 && placa.Contains("-")) // Verificar se a placa tem um formato específico
        {
            veiculos.Add(placa);
            
            Console.WriteLine($"Veículo com placa: {placa} adicionado com sucesso!");
        }
        else {
            Console.WriteLine("placa inválida, tente novamente.");

        }
        }

        
        public void RemoverVeiculo()
        {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal   

            Console.WriteLine("Digite a placa do veículo para remover:");
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            
            string placa = Console.ReadLine();
           

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            string horasString = Console.ReadLine();

            if (int.TryParse(horasString, out int horas))
            {
               
            decimal valorTotal = precoInicial + precoPorHora * horas; 
            
            
            // TODO: Remover a placa digitada da lista de veículos

            Console.WriteLine($"Você deseja remover o veículo {placa}? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta == "S")
            {
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }

            else
            {
                Console.WriteLine("Operação cancelada.");
            }
                // TODO: Remover a placa digitada da lista de veículos
               
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        }
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {

                Console.WriteLine("Os veículos estacionados são:");
            

                for(int cont = 0; cont < veiculos.Count; cont++){
                Console.WriteLine($"Estacionamento Nº {cont + 1} - Placa: {veiculos[cont]}");
            }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
