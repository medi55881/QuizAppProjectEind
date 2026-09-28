namespace QuizApp.ZonderDatabase
{
    // Eén vraag uit de quiz.
    // Is OptionA leeg? Dan is het een open vraag. Anders is het een meerkeuzevraag.
    public class Question
    {
        public string Text { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string CorrectAnswer { get; set; }   // "A", "B", "C" of het antwoord van een open vraag

        // Met deze constructor kan ik een vraag in één regel maken.
        public Question(string text, string optionA, string optionB, string optionC, string correctAnswer)
        {
            Text = text;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            CorrectAnswer = correctAnswer;
        }

        public bool IsOpenQuestion()
        {
            return OptionA == "";
        }
    }
}
