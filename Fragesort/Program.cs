using System;

namespace Fragesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int rätt = 0;
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();

            Console.WriteLine("Hej " + namn + ". Vill du spela min frågesport?");
            string svar = Console.ReadLine();
            svar = svar.ToLower();

            if (svar == "nej")
            {

            }
            else
            {
                Console.WriteLine("Fråga 1. Vilket är världens största spel genom tiderna?");
                Console.WriteLine("a) Minecraft");
                Console.WriteLine("b) Tetris");
                Console.WriteLine("c) GTA V");

                string svar1 = Console.ReadLine();
                svar1 = svar1.ToLower();
                if (svar1 == "a" || svar1 == "minecraft")
                {
                    Console.WriteLine("Grattis det var rätt!");
                    rätt++;

                }
                else
                {
                    Console.WriteLine("Det var tyvärr fel.");
                }
                Console.ReadLine();
                Console.WriteLine("Hur många gånger har Estland vunnigt Eurovision?");
                Console.WriteLine("a) 0");
                Console.WriteLine("b) 5");
                Console.WriteLine("c) 1");
                string svar2 = Console.ReadLine();
                if (svar2 == "c" || svar2 == "1")
                {
                    Console.WriteLine("Grattis det var rätt!");
                    rätt++;
                }
                else
                {
                    Console.WriteLine("Det var tyvärr fel");
                }
                Console.ReadLine();
                Console.WriteLine("Vilkt år började vi i gymnasiet?");
                Console.WriteLine("a) 2020");
                Console.WriteLine("b) 2019");
                Console.WriteLine("c) 2018");
                string svar3 = Console.ReadLine();
                if (svar3 == "b" || svar3 == "2019")
                {
                    Console.WriteLine("Grattis det var rätt");
                    rätt++;
                }
                else
                {
                    Console.WriteLine("Det var tyvärr fel.");
                }

                if (rätt == 3)
                {
                    Console.WriteLine("Du fick full pott. Grattis!");
                }
                else if (rätt >= 1)
                {
                    Console.WriteLine("Det var nästan full pott. Grattis");
                }
                else
                {
                    Console.WriteLine("Det var riktigt dåligt jobbat");
                }
                Console.WriteLine("Du fick " + rätt + " rätt");
                Console.ReadLine();

            }
        }
    }
}

