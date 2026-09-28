# QuizApp.ZonderDatabase

Een quiz-app in de console, **zonder database**.
Alle vragen en resultaten staan in lijsten in het geheugen (`QuizData.cs`).
De startvragen staan vast in de code (hard-coded).

Let op: sluit je de app, dan zijn nieuwe vragen en resultaten weg.

## Starten

Open `QuizApp.ZonderDatabase.csproj` in Visual Studio en druk op **F5**.

## Lees de code in deze volgorde

1. `Question.cs` – hoe één vraag eruitziet
2. `QuizResult.cs` – hoe één poging en één antwoord eruitzien
3. `QuizData.cs` – de lijsten + de vaste vragen
4. `Program.cs` – de start en het menu
5. `QuizScreen.cs` – de student maakt de quiz
6. `QuestionsScreen.cs` – de docent beheert de vragen
7. `ResultsScreen.cs` – de docent bekijkt de resultaten
