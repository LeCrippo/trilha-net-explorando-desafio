using System.IO.Compression;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

bool exibirMenu = true;

Menu menu = new Menu();

Console.WriteLine("\nSistema de Cadastros e Controle de Custos\n");
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("------------------------------------------");
    Console.WriteLine("Digite 1 para cadastrar hóspede");
    Console.WriteLine("Digite 2 para cadastrar suite");
    Console.WriteLine("Digite 3 para obter quantidade de Hospedes");
    Console.WriteLine("Digite 4 para calcular valor total");
    Console.WriteLine("Digite 5 para sair");
    Console.WriteLine("------------------------------------------");


    switch (Console.ReadLine())
    {
        case "1":

            Console.WriteLine("Cadastrando novo Hóspede:");
            menu.CadastrarHospedes();
            break;

        case "2":

            Console.WriteLine("Cadastrando a Suite:");
            menu.CadastrarSuite();
            menu.ApresentarSuite();
            break;

        case "3":

            menu.ApresentarQuantidadeHospedes();
            break;

        case "4":

            menu.ApresentarCalculoValorDiaria();
            break;

        case "5":

            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
