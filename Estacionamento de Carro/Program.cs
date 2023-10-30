// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite o Preço Inicial do Estacionamento:");
int precoinicial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o Preço por Hora:");
int precohora = Convert.ToInt32(Console.ReadLine());

bool menu = true;

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
            
            break;
        case "2":
            
            break;
        case "3":

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