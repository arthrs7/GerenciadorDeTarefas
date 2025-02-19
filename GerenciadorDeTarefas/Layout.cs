using System;

namespace Layout
{
    public static class Formatacao
    {
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void ImprimirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("================================");
            Console.WriteLine("|    GERENCIADOR DE TAREFAS    |");
            Console.WriteLine("================================");
            Console.ResetColor();
        }
    }
}
