// See https://aka.ms/new-console-template for more information

using Examen1Lib;

namespace Examen1App
{
    class Program
    {
        // === Create object ===
        private static Song _song1;
        private static Song _song2;
        private static Song _song3;
        private static Song _song4;
        private static Song _song5;
        private static Song _song6;
        private static Song _song7;
        private static Song _song8;
        private static Song _song9;
        private static Song _song10;
        private static Song _song11;
        private static Song _song12;
        private static Playlist _list1;
        private static Playlist _list2;
        private static Playlist _list3;


        //  === Assing value to the proper object ===
        public static void DataSetup()
        {
            _song1 = new Song("Ayayaya j'ai mal ", "Johny Pineault", 9);
            _song2 = new Song("J'ai encore mal", "Johny Pineault", 75);
            _song3 = new Song("Mes bottine non souriante", "Yellow chaussure", 137);
            _song4 = new Song("Attache les cordon", "Yellow chaussure", 150);
            _song5 = new Song("Moi et mes velcro", "Sketchers", 96);
            _song6 = new Song("Perdu ma 10mm", "Le coffre a outil", 245);
            _song7 = new Song("Mes main noir", "Le coffre a outil", 205);
            _song8 = new Song("Casser la bolt", "Sacre moteur", 215);
            _song9 = new Song("Ma nouvelle tablette", "Samsung", 168);
            _song10 = new Song("Check mon S Pen", "Samsung", 124);
            _song11 = new Song("Mennui de mon palm Tungsten e2", "La techno retro", 111);
            _song12 = new Song("Ou est mon pentium 1 ", "La techno retro", 134);
            _list1 = new Playlist("The supper dupper list");
            _list1.Songlist.Add(_song1);
            _list1.Songlist.Add(_song2);
            _list1.Songlist.Add(_song3);
            _list1.Songlist.Add(_song4);
            _list1.Songlist.Add(_song5);

            _list2 = new Playlist("La ballade du garage");
            _list2.Songlist.Add(_song6);
            _list2.Songlist.Add(_song7);
            _list2.Songlist.Add(_song8);

            _list3 = new Playlist("Techno !!");
            _list3.Songlist.Add(_song9);
            _list3.Songlist.Add(_song10);
            _list3.Songlist.Add(_song11);
            _list3.Songlist.Add(_song12);
        }


        static void Main()
        {
            DataSetup(); // Initialize all data for the program
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
                              "|Examen Prog Orienter objet 24 avril 2022 |\n" + // So Much wow
                              "|Hello enter a choice or type quit to exit|\n" +
                              "|1. Music Player                          |\n" +
                              "*******************************************");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1": // If 2 is entered, will point to the number 2 program
                    bool showPlayer = true; // Set showmain to true so the loop can run
                    while (showPlayer) // = while true since showMain is bool
                    {
                        showPlayer = Player(); // Call function MainMenu
                    }

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


        public static bool Player()
        {
            Console.Clear(); // Stating blank !


            Console.WriteLine("*******************************************\n" + // Nice menu
                              "|Super supra music player !               |\n" + // So Much wow
                              "|Hello enter a choice or type (main) to   |\n" +
                              "|exit to the main menu or (quit) to end   |\n" +
                              "*******************************************");
            Console.WriteLine($"{_list1.Id}: {_list1.Name} which contain : {_list1.Count} song(s)!"); // display list
            Console.WriteLine($"{_list2.Id}: {_list2.Name} which contain : {_list2.Count} song(s)!");
            Console.WriteLine($"{_list3.Id}: {_list3.Name} which contain : {_list3.Count} song(s)!");
            switch (Console.ReadLine()) // Read input and case it or reject it
            {
                case "1": // If 1 is entered, will point to the number 1 program

                    Console.Clear();
                    Console.WriteLine(
                        $"The playlist {_list1.Name} is {_list1.TotalLenghtFormated} long and contain :\n");
                    Console.WriteLine($"{_list1}");
                    EndOfFunction("Press enter to return to selector");
                    return true;
                case "2": // If 2 is entered, will point to the number 2 program
                    Console.Clear();
                    Console.WriteLine(
                        $"The playlist {_list2.Name} is {_list2.TotalLenghtFormated} long and contain :\n");
                    Console.WriteLine($"{_list2}");
                    EndOfFunction("Press enter to return to selector");
                    return true;
                case "3": // If 3 is entered, will point to the number 1 program
                    Console.Clear();
                    Console.WriteLine(
                        $"The playlist {_list3.Name} is {_list3.TotalLenghtFormated} long and contain :\n");
                    Console.WriteLine($"{_list3}");
                    EndOfFunction("Press enter to return to selector");
                    return true;
                case "main": // Will return false to Main so it stop the prog

                    return false;
                case "quit": // Will exit ASAP
                    Environment.Exit(0);
                    return true;


                default: // In case something bad happen aka wrong input
                    return true;
            }
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

        private static void EndOfFunction(string message)
        {
            Console.WriteLine(message); // 
            Console.ReadLine(); // Pause and wait for an input
            Console.Clear();
        }
    }
}