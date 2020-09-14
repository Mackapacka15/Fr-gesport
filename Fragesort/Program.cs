using System;

namespace Fragesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int rätt = 0;
            string svar1 = "", svar2 = "", svar3 = "", svar4 = "";
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();

            Console.WriteLine("Hej " + namn + ". Vill du spela min frågesport?");
            string svar = Console.ReadLine();
            svar = svar.ToLower();
            while (start == 1)
            {

                if (svar == "nej")
                {

                }
                else
                {
                    Console.WriteLine("");
                    while (svar1 != "a" && svar1 != "b" && svar1 != "c" && svar1 != "minecraft" && svar1 != "tetris" && svar1 != "gtav")
                    {
                        Console.WriteLine("Fråga 1. Vilket är världens största spel genom tiderna?");
                        Console.WriteLine("a) Minecraft");
                        Console.WriteLine("b) Tetris");
                        Console.WriteLine("c) GTA V");

                        svar1 = Console.ReadLine();
                        svar1 = svar1.ToLower();
                    }
                    if (svar1 == "a" || svar1 == "minecraft")
                    {
                        Console.WriteLine("Grattis det var rätt!");
                        rätt++;

                    }
                    else
                    {
                        Console.WriteLine("Det var tyvärr fel.");
                    }

                    Console.WriteLine("");
                    while (svar2 != "a" && svar2 != "b" && svar2 != "c" && svar2 != "0" && svar2 != "1" && svar2 != "5")
                    {
                        Console.WriteLine("Hur många gånger har Estland vunnigt Eurovision?");
                        Console.WriteLine("a) 0");
                        Console.WriteLine("b) 5");
                        Console.WriteLine("c) 1");
                        svar2 = Console.ReadLine();
                        svar2 = svar2.ToLower();
                    }
                    if (svar2 == "c" || svar2 == "1")
                    {
                        Console.WriteLine("Grattis det var rätt!");
                        rätt++;
                    }
                    else
                    {
                        Console.WriteLine("Det var tyvärr fel");
                    }
                    Console.WriteLine("");
                    while (svar3 != "a" && svar3 != "b" && svar3 != "c" && svar3 != "2020" && svar3 != "2019" && svar3 != "2018")
                    {
                        Console.WriteLine("Vilkt år började vi i gymnasiet?");
                        Console.WriteLine("a) 2020");
                        Console.WriteLine("b) 2019");
                        Console.WriteLine("c) 2018");
                        svar3 = Console.ReadLine();
                    }
                    if (svar3 == "b" || svar3 == "2019")
                    {
                        Console.WriteLine("Grattis det var rätt");
                        rätt++;
                    }
                    else
                    {
                        Console.WriteLine("Det var tyvärr fel.");
                    }
                    Console.WriteLine("");
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
                    Console.WriteLine("");

                }
                Console.WriteLine("Vill du köra en gång till?");
                svar4 = Console.ReadLine();
                svar4 = svar4.ToLower();

                if (svar4 == "nej")
                {
                    start--;
                }
            }
        }
    }
}

