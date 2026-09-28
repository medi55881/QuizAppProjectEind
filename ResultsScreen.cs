using System;

namespace QuizApp.ZonderDatabase
{
    public static class ResultsScreen
    {
        public static void Start()
        {
            if (QuizData.Results.Count == 0)
            {
                Console.WriteLine("Nog geen resultaten. Laat eerst een student de quiz maken.");
                return;
            }

            ShowResults();

            Console.Write("Nummer van een poging voor de antwoorden (Enter = terug): ");
            string input = Console.ReadLine().Trim();
            if (input == "")
            {
                return;
            }

            int number;
            if (!int.TryParse(input, out number) || number < 1 || number > QuizData.Results.Count)
            {
                Console.WriteLine("Kies een nummer uit de lijst.");
                return;
            }

            ShowAnswers(QuizData.Results[number - 1]);
        }

        private static void ShowResults()
        {
            for (int i = 0; i < QuizData.Results.Count; i++)
            {
                QuizResult result = QuizData.Results[i];
                Console.WriteLine((i + 1) + ". " + result.DateTaken.ToString("dd-MM-yyyy HH:mm") + "   "
                    + result.StudentName + "   score: " + result.Score + " / " + result.TotalQuestions);
            }
        }

        private static void ShowAnswers(QuizResult result)
        {
            foreach (QuizAnswer answer in result.Answers)
            {
                string goodOrWrong = "FOUT";
                if (answer.IsCorrect)
                {
                    goodOrWrong = "GOED";
                }

                Console.WriteLine(goodOrWrong + "   " + answer.QuestionText
                    + "   gegeven: " + answer.GivenAnswer + "   juist: " + answer.CorrectAnswer);
            }
        }
    }
}
