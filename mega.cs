using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public static class Program
{
    public static void Main()
    {
        var vencedor = new [] { 02, 18, 31, 42, 51, 56 };
        var jogos = File.ReadAllLines("mega.txt").Select(x => x.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(y => int.Parse(y)).ToList()).ToList();

        Console.WriteLine("Jogo vencedor: {0}", string.Join(", ", vencedor));

        foreach(var jogo in jogos)
        {
            var count = 0;
            foreach(var j in jogo)
            {
                if (vencedor.Contains(j))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    count++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.Write(" {0,2} ", j);

            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" => {0} acertos \n", count);
        }
        Console.Read();
    }
}
