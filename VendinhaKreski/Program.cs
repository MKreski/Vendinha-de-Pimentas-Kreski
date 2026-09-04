// See https://aka.ms/new-console-template for more information
Console.WriteLine("Menu de teste");

bool menu = true;
while (menu)
{
    Console.WriteLine("=====================================");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("[1] - Adicionar Cliente");
    Console.WriteLine("[2] - Listar Clientes");
    Console.WriteLine("[3] - Editar Cliente");
    Console.WriteLine("[4] - Deletar Cliente");
    Console.WriteLine("[0] - Sair");
    var opcao = 0;

    try
    {
        bool opc = int.TryParse(Console.ReadLine(), out opcao);
        if (opc)
        {
            Console.WriteLine($"Opção escolhida: {opcao}");
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Adicionar Cliente");
                    break;
                case 2:
                    Console.WriteLine("Listar Clientes");
                    break;
                case 3:
                    Console.WriteLine("Editar Cliente");
                    break;
                case 4:
                    Console.WriteLine("Deletar Cliente");
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    menu = false;
                    break;
            }
        }
        else
        {
            Console.WriteLine("\n-=Opção inválida=-\n");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
        menu = false;
    }
}
