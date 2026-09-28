using System;
using System.Collections.Generic;

namespace QuizApp.ZonderDatabase
{
    // Eén keer dat een student de quiz heeft gemaakt.
    public class QuizResult
    {
        public string StudentName { get; set; }
        public int Score { get; set; }
        public int TotalQuestions { get; set; }
        public DateTime DateTaken { get; set; }

        // Eén resultaat heeft veel antwoorden (one-to-many).
        public List<QuizAnswer> Answers { get; set; } = new List<QuizAnswer>();
    }

    // Het antwoord van een student op één vraag.
    public class QuizAnswer
    {
        public string QuestionText { get; set; }
        public string GivenAnswer { get; set; }
        public string CorrectAnswer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
