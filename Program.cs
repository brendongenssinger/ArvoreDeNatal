using System;
using System.Collections.Generic;
using System.Threading;

namespace ArvoreNatalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Arvore de Natal AspNet Core.!");
            ExecutarArvoreNatal();
            System.Console.WriteLine("Arvore criada");
            Console.ReadLine();
        }


        

        private static void ExecutarArvoreNatal()
        {
            var estrela = string.Empty;
            var pad = 50;
            var lista = new List<string>();
            var listaCores = new List<ConsoleColor>()
            {
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.White,
                ConsoleColor.Red
            };

            var x = Console.CursorLeft;
            var y = Console.CursorTop;

            while(true)
            {
                Console.SetCursorPosition(x,y);
                foreach(var cor in listaCores)
                {
                    Console.SetCursorPosition(x,y);

                    for(var i=0;i<8;i++)
                    {
                        lista.Add("    * ");
                        Console.ForegroundColor = cor;
                        Console.SetCursorPosition(x+i,y+i);
                        System.Console.WriteLine(string.Join("",lista).PadLeft(pad));
                        pad++;
                        pad++;
                    
                    }

                    System.Console.WriteLine("");
                    System.Console.WriteLine("||   ||".PadLeft(52));
                    System.Console.WriteLine("||   ||".PadLeft(52));
                    System.Console.WriteLine("");
                    System.Console.WriteLine("");

                    System.Console.WriteLine("** Feliz Natal **".PadLeft(57));
                    Thread.Sleep(100);
                    pad = 50;
                    lista.Clear();
                    Console.Clear();
                }
            }
        }
    }
}
