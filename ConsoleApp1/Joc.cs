using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joc;

namespace Joc_Main
{
    class Joc
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.Clear();
                Console.WriteLine("S. Incepere Joc!");
                Console.WriteLine("X. Exit");
                Console.Write("Optiunea Dumneavoastra: ");
                string optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "S":
                        inceputJoc();
                        break;
                    case "X":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (!exit);
        }

        static void inceputJoc()
        {
            VerificareRaspunsuri Verificare = new VerificareRaspunsuri();

            Console.Clear();

            Console.WriteLine("Intrebarea 1: Care este cel mai mare animal?");
            
            Console.WriteLine("a) Elefantul");
            Console.WriteLine("b) Soimul");
            Console.WriteLine("c) Girafa");

            Console.Write("Raspunsul tau: ");
            string answer1 = Console.ReadLine();

            if (Verificare.VerifRaspuns("a", answer1))
            {
                Console.WriteLine("Corect!");
                Verificare.ScrieRezultat("Intrebarea 1: ", answer1);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gresit. Raspunsul corect era a, Elefantul.");
                Console.ReadKey();
            }

            Console.Clear();

            Console.WriteLine("Intrebarea 2: Care este cel mai rapid animal?");
            Console.WriteLine("a) Ghepard");
            Console.WriteLine("b) Leul");
            Console.WriteLine("c) Elefantul");
            Console.Write("Raspunsul tau: ");
            string answer2 = Console.ReadLine();

            if (Verificare.VerifRaspuns("a", answer2))
            {
                Console.WriteLine("Corect!");
                Verificare.ScrieRezultat("Intrebarea 2", answer2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gresit. Raspunsul corect era a, Ghepard.");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Intrebarea 3: Care este cel mai incet animal?");
            Console.WriteLine("a) Elefantul");
            Console.WriteLine("b) Girafa");
            Console.WriteLine("c) Melcul");
            Console.Write("Raspunsul tau: ");
            string answer3 = Console.ReadLine();

            if (Verificare.VerifRaspuns("c", answer3))
            {
                Console.WriteLine("Corect!");
                Verificare.ScrieRezultat("Intrebarea 3", answer3);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gresit. Raspunsul corect era c, Melcul.");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("Intrebarea 4: Care animal face Miau?");
            Console.WriteLine("a) Pisica");
            Console.WriteLine("b) Cainele");
            Console.WriteLine("c) Vulpea");
            Console.Write("Raspunsul tau: ");
            string answer4 = Console.ReadLine();

            if (Verificare.VerifRaspuns("a", answer4))
            {
                Console.WriteLine("Corect!");
                Verificare.ScrieRezultat("Intrebarea 4", answer4);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gresit. Raspunsul corect era a, Melcul.");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Intrebarea 5: Care animal este cel mai bun prieten al omului?");
            Console.WriteLine("a) Lupul");
            Console.WriteLine("b) Cainele");
            Console.WriteLine("c) Calul");
            Console.Write("Raspunsul tau: ");
            string answer5 = Console.ReadLine();

            if (Verificare.VerifRaspuns("b", answer5))
            {
                Console.WriteLine("Corect!");
                Verificare.ScrieRezultat("Intrebarea 5", answer5);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gresit. Raspunsul corect era b, Cainele.");
                Console.ReadKey();
            }





            Console.WriteLine($"\nFelicitari! Ai raspuns la {Verificare.Score} raspunsuri corect!");
            Console.ReadKey();
        }
    }
}