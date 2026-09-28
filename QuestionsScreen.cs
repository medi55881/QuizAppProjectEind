using System;

namespace QuizApp.ZonderDatabase
{
    public static class QuestionsScreen
    {
        public static void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine();
                Console.WriteLine("=== Vragen beheren ===");
                Console.WriteLine("1. Alle vragen tonen");
                Console.WriteLine("2. Vraag toevoegen");
                Console.WriteLine("3. Vraag wijzigen");
                Console.WriteLine("4. Vraag verwijderen");
                Console.WriteLine("0. Terug naar het menu");
                Console.Write("Kies: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ShowQuestions();
                }
                else if (choice == "2")
                {
                    AddQuestion();
                }
                else if (choice == "3")
                {
                    EditQuestion();
                }
                else if (choice == "4")
                {
                    DeleteQuestion();
                }
                else if (choice == "0")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Kies 1, 2, 3, 4 of 0.");
                }
            }
        }

        private static void ShowQuestions()
        {
            if (QuizData.Questions.Count == 0)
            {
                Console.WriteLine("Er zijn nog geen vragen.");
                return;
            }

            for (int i = 0; i < QuizData.Questions.Count; i++)
            {
                Question question = QuizData.Questions[i];
                Console.WriteLine((i + 1) + ". " + question.Text + "   (juist: " + question.CorrectAnswer + ")");
            }
        }

        private static string ReadText(string label)
        {
            Console.Write(label + " ");
            return Console.ReadLine().Trim();
        }

        private static Question ReadQuestion()
        {
            Console.WriteLine("Meerkeuze: vul A, B, C in en als juiste antwoord A, B of C. Open vraag: laat A, B, C leeg.");
            string text = ReadText("Vraag:");
            string a = ReadText("Antwoord A:");
            string b = ReadText("Antwoord B:");
            string c = ReadText("Antwoord C:");
            string correct = ReadText("Juiste antwoord:");

            string error = CheckInput(text, a, b, c, correct);
            if (error != "")
            {
                Console.WriteLine(error);
                return null;
            }

            if (a != "")
            {
                correct = correct.ToUpper();
            }
            return new Question(text, a, b, c, correct);
        }

        private static string CheckInput(string text, string a, string b, string c, string correct)
        {
            correct = correct.ToUpper();

            if (text == "" || correct == "")
            {
                return "Vul minstens de vraag en het juiste antwoord in.";
            }

            bool isOpenQuestion = a == "" && b == "" && c == "";
            if (!isOpenQuestion && (a == "" || b == "" || c == ""))
            {
                return "Vul A, B en C alle drie in, of laat ze alle drie leeg (open vraag).";
            }

            if (!isOpenQuestion && correct != "A" && correct != "B" && correct != "C")
            {
                return "Bij een meerkeuzevraag is het juiste antwoord A, B of C.";
            }

            return "";
        }

        private static int AskQuestionNumber()
        {
            ShowQuestions();
            string input = ReadText("Nummer van de vraag:");

            int number;
            if (!int.TryParse(input, out number) || number < 1 || number > QuizData.Questions.Count)
            {
                Console.WriteLine("Kies een nummer uit de lijst.");
                return -1;
            }
            return number - 1;
        }

        private static void AddQuestion()
        {
            Question question = ReadQuestion();
            if (question == null)
            {
                return;
            }

            QuizData.Questions.Add(question);
            Console.WriteLine("De vraag is toegevoegd.");
        }

        private static void EditQuestion()
        {
            int index = AskQuestionNumber();
            if (index == -1)
            {
                return;
            }

            Question question = ReadQuestion();
            if (question == null)
            {
                return;
            }

            QuizData.Questions[index] = question;
            Console.WriteLine("De vraag is gewijzigd.");
        }

        private static void DeleteQuestion()
        {
            int index = AskQuestionNumber();
            if (index == -1)
            {
                return;
            }

            string sure = ReadText("Deze vraag verwijderen? (j/n):");
            if (sure.ToLower() != "j")
            {
                Console.WriteLine("Niet verwijderd.");
                return;
            }

            QuizData.Questions.RemoveAt(index);
            Console.WriteLine("De vraag is verwijderd.");
        }
    }
}
