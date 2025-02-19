using System;
using GerenciarTarefa;
using Layout;

class Program
{
    static void Main()
    {
        string opcao;

        do
        {
            Console.Clear();
            Formatacao.ImprimirCabecalho();

            Console.WriteLine("\n1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");
            opcao = Console.ReadLine();

            Console.Clear();
            Formatacao.ImprimirCabecalho();
            
            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    Gerenciador.AdicionarTarefa(descricao);
                    break;
                case "2":
                    Gerenciador.ListarTarefa();
                    break;
                case "3":
                    Gerenciador.ConcluirTarefa();
                    break;
                case "4":
                    Gerenciador.RemoverTarefa();
                    break;
                case "0":
                    Formatacao.Cor("Saindo...", ConsoleColor.Red);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        } while (opcao != "0");
    } 
}
