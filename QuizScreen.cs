using System;
using System.Collections.Generic;

namespace QuizApp.ZonderDatabase
{
    public static class QuizScreen
    {
        public static void Start()
        {
            Console.Write("Jouw naam: ");
            string name = Console.ReadLine().Trim();
            if (name == "")
            {
                Console.WriteLine("Vul eerst je naam in.");
                return;
            }

            if (QuizData.Questions.Count == 0)
            {
                Console.WriteLine("Er zijn nog geen vragen. Vraag de docent om vragen te maken.");
                return;
            }

            List<QuizAnswer> answers = new List<QuizAnswer>();
            for (int i = 0; i < QuizData.Questions.Count; i++)
            {
                Question question = QuizData.Questions[i];
                ShowQuestion(question, i);
                string given = GetGivenAnswer(question);

                QuizAnswer answer = new QuizAnswer();
                answer.QuestionText = question.Text;
                answer.GivenAnswer = given;
                answer.CorrectAnswer = question.CorrectAnswer;
                answer.IsCorrect = CheckAnswer(given, question.CorrectAnswer);
                answers.Add(answer);
            }

            FinishQuiz(name, answers);
        }

        private static void ShowQuestion(Question question, int index)
        {
            Console.WriteLine();
            Console.WriteLine((index + 1) + " / " + QuizData.Questions.Count + ". " + question.Text);
            if (!question.IsOpenQuestion())
            {
                Console.WriteLine("  A: " + question.OptionA);
                Console.WriteLine("  B: " + question.OptionB);
                Console.WriteLine("  C: " + question.OptionC);
            }
        }

        private static string GetGivenAnswer(Question question)
        {
            while (true)
            {
                if (question.IsOpenQuestion())
                {
                    Console.Write("Jouw antwoord: ");
                }
                else
                {
                    Console.Write("Jouw antwoord (A, B of C): ");
                }

                string given = Console.ReadLine().Trim();

                if (given == "")
                {
                    Console.WriteLine("Typ eerst een antwoord.");
                }
                else if (!question.IsOpenQuestion() && given.ToUpper() != "A" && given.ToUpper() != "B" && given.ToUpper() != "C")
                {
                    Console.WriteLine("Kies A, B of C.");
                }
                else
                {
                    return given;
                }
            }
        }

        private static bool CheckAnswer(string given, string correct)
        {
            return given.Trim().ToLower() == correct.Trim().ToLower();
        }

        private static void FinishQuiz(string name, List<QuizAnswer> answers)
        {
            int score = 0;
            foreach (QuizAnswer answer in answers)
            {
                if (answer.IsCorrect)
                {
                    score++;
                }
            }

            QuizResult result = new QuizResult();
            result.StudentName = name;
            result.Score = score;
            result.TotalQuestions = answers.Count;
            result.DateTaken = DateTime.Now;
            result.Answers = answers;

            QuizData.Results.Add(result);

            Console.WriteLine();
            Console.WriteLine(name + ", je score is " + score + " / " + answers.Count);
        }
    }
}
