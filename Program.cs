using System;

namespace QuizApp.ZonderDatabase
{
    class Program
    {
        static void Main()
        {
            QuizData.AddStartQuestions();

            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("=== Quiz-applicatie ===");
                Console.WriteLine("1. Quiz maken (student)");
                Console.WriteLine("2. Vragen beheren (docent)");
                Console.WriteLine("3. Resultaten bekijken (docent)");
                Console.WriteLine("0. Stoppen");
                Console.Write("Kies: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    QuizScreen.Start();
                }
                else if (choice == "2")
                {
                    QuestionsScreen.Start();
                }
                else if (choice == "3")
                {
                    ResultsScreen.Start();
                }
                else if (choice == "0")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Kies 1, 2, 3 of 0.");
                }
            }
        }
    }
}
