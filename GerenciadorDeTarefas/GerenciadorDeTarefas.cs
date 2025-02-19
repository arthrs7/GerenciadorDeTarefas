using System;
using System.Collections.Generic;
using Tarefas;
using Layout;

namespace GerenciarTarefa
{
    public static class Gerenciador
    {
        private static List<Tarefa> listaTarefas = new List<Tarefa>();
        private static int contadorId = 1;

        public static void AdicionarTarefa(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                Formatacao.Cor("Erro: A descrição da tarefa não pode ser vazia!", ConsoleColor.Red);
                return;
            }
            if (listaTarefas.Exists(t => t.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase)))
            {
                Formatacao.Cor("Erro: Já existe uma tarefa com essa descrição!", ConsoleColor.Red);
                return;
            }
            listaTarefas.Add(new Tarefa(contadorId++, descricao));
            Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
        }

        public static void ListarTarefa()
        {
            Formatacao.Cor("Tarefas:", ConsoleColor.Yellow);
            if (listaTarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada.");
                return;
            }
            foreach (var tarefa in listaTarefas)
            {
                tarefa.ExibirTarefa();
            }
        }

        public static void ConcluirTarefa()
        {
            ListarTarefa();
            Console.Write("Digite o ID da tarefa a concluir: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var tarefa = listaTarefas.Find(t => t.Id == id);
                if (tarefa != null)
                {
                    tarefa.Concluida = true;
                    Formatacao.Cor("Tarefa concluída!", ConsoleColor.Green);
                }
                else
                {
                    Formatacao.Cor("Tarefa não encontrada!", ConsoleColor.Red);
                }
            }
            else
            {
                Formatacao.Cor("ID inválido!", ConsoleColor.Red);
            }
        }

        public static void RemoverTarefa()
        {
            ListarTarefa();
            Console.Write("Digite o ID da tarefa a remover: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var tarefa = listaTarefas.Find(t => t.Id == id);
                if (tarefa != null)
                {
                    listaTarefas.Remove(tarefa);
                    Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Red);
                }
                else
                {
                    Formatacao.Cor("Tarefa não encontrada!", ConsoleColor.Red);
                }
            }
            else
            {
                Formatacao.Cor("ID inválido!", ConsoleColor.Red);
            }
        }
    }
}
