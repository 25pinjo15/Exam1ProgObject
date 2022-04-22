// See https://aka.ms/new-console-template for more information

using Examen1Lib;

namespace Examen1App
{


    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Display special caracter
            bool showMain = true; // Set showmain to true so the loop can run
            while (showMain) // = while true since showMain is bool
            {
                showMain = MainMenu(); // Call function MainMenu
            }
        }

        private static bool MainMenu()
        {
            Console.Clear(); // Stating blank !

            Console.WriteLine("*******************************************\n" + // Nice menu
                              "|Exercise Prog Objet 14 avril             |\n" + // So Much wow
                              "|Hello enter a choice or type quit to exit|\n" +
                              "|1. Dice Game 1                           |\n" +
                              "|2. Dice Game 2                           |\n" +
                              "*******************************************");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1": // If 1 is entered, will point to the number 1 program
                    Game1();
                    return true;
                case "2": // If 2 is entered, will point to the number 2 program
                    Game2();
                    return true;

                case "quit": // Will return false to Main so it stop the prog
                    Console.Clear(); // Display an exit message
                    Console.WriteLine("thank you, exited without error");
                    return false;

                default: // In case something bad happen aka wrong input
                    return true;
            }
        }


        // Function for the number one problem
        // Should consider each input check if its good. take in mind the number of student over the average and ect ... 
        private static void Game1()
        {
            Console.Clear();
            Song song1 = new Song("ayayaya j'ai mal ", "johny pineault", 70);
            Console.WriteLine(song1.Minute);
            Console.WriteLine(song1);
            EndOfFunction();
        }

        private static void Game2()
        {
            
        }

        public static int UserNumberInput(string texte = "")
        {
            // === Variable declaration
            int output = 0; // Used for input output purpose
            bool tryParse = false; // Used for the loop to make sure its a number 
            // === Function main

            do
            {
                Console.Write(texte); // Write asked text
                tryParse = int.TryParse(Console.ReadLine(), out output); // Try to parse the input 
            } while (tryParse != true); // If try parse success ... continue

            return (output);
        }

        public static string UserStringInput(string texte = "")
        {
            // === Variable declaration
            string output = null; // Used for I/O purpose
            // === Function main


            Console.Write(texte);
            output = Console.ReadLine();

            return output;
        }

        private static void EndOfFunction()
        {
            Console.WriteLine("\nPress enter to return to main menu"); // 
            Console.ReadLine(); // Pause and wait for an input
            Console.Clear();
        }
    }
}