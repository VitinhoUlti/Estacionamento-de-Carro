// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite o Preço Inicial do Estacionamento:");
int precoinicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Preço por Hora:");
int precohora = Convert.ToInt32(Console.ReadLine());

bool menu = true;
List<string?> carros = new List<string?>();

while(menu)
{
    Console.Clear();

    Console.WriteLine("Digite a opção");
    Console.WriteLine("1 - Cadastrar Veiculo");
    Console.WriteLine("2 - Remover Veiculo");
    Console.WriteLine("3 - Listar Veiculos");
    Console.WriteLine("4 - Encerrar");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do veiculo que estacionou:");
            carros.Add(Console.ReadLine());
            break;
        case "2":
            Console.WriteLine("Digite a placa do veiculo que ira sair:");
            carros.Remove(Console.ReadLine());

            Console.WriteLine("Digite Quanto tempo ele ficou:");
            int total = (Convert.ToInt32(Console.ReadLine()) * precohora) + precoinicial;

            Console.WriteLine($"Ele tera que pagar {total} reais");
            break;
        case "3":
            Console.WriteLine("Esses são os carros que estão no estabelecimento");
            foreach (var item in carros)
            {
                Console.WriteLine(item);
            }
            break;
        case "4":
            menu = false;
            break;
        default:
            Console.WriteLine("Opção Invalida");
            break;
    }

    if (menu)
    {
        Console.WriteLine("Digite algo para Voltar");
        Console.ReadKey();
    }
}