using System.Collections.Generic;

namespace QuizApp.ZonderDatabase
{
    public static class QuizData
    {
        public static List<Question> Questions = new List<Question>();
        public static List<QuizResult> Results = new List<QuizResult>();

        public static void AddStartQuestions()
        {
            Questions.Add(new Question("Wat is een programmeertaal?", "Cobra", "Python", "Mamba", "B"));
            Questions.Add(new Question("Waar staan de beste stuurlui volgens het spreekwoord?", "Aan land", "Aan het roer", "Aan wal", "C"));
            Questions.Add(new Question("Hoe vaak stoot een ezel zich over het algemeen aan een steen?", "Nooit", "Meer dan 1 keer", "Niet 2 keer", "C"));
            Questions.Add(new Question("Waarheen valt een appel volgens het spreekwoord?", "Van de boom op de grond", "Niet ver van de boom", "Laag bij de grond", "B"));
            Questions.Add(new Question("Wat ligt er op de grond in de hotelkamer van Guus Meeuwis na een nacht die je normaal alleen in films ziet?", "Lakens en een leeg krat bier", "de beddensprei en een lege fles wijn", "een lege fles wijn en kledingstukken die van jou of mij kunnen zijn", "C"));
            Questions.Add(new Question("Hoe hoog is de toren van de grote kerk in Breda?", "89 meter", "97 meter", "97.5 meter", "B"));
            Questions.Add(new Question("Wat is het volledige adres van de Curio vestiging in Breda waar de opleiding SD verzorgd wordt?", "Terheijdenseweg 350, 4826 AA, Breda", "Terheijdenseweg 355, 4826 AA, Breda", "Terheijdenseweg 350, 4826 AB, Breda", "A"));
            Questions.Add(new Question("Wat is het volledige adres van de Curio vestiging in Roosendaal waar de opleiding SD verzorgd wordt?", "Knipplein 11, 4702 GN, Roosendaal", "Knipplein 21, 4703 GN, Roosendaal", "Knipplein 11, 4702 GM, Roosendaal", "A"));
            Questions.Add(new Question("Welk land heeft de meeste eilanden ter wereld?", "Zweden", "Indonesie", "Hawaii", "A"));
            Questions.Add(new Question("Wat is de best verkochte boekenreeks van de 21e eeuw?", "Lord of the Rings", "Harry Potter", "Narnia", "B"));
            Questions.Add(new Question("Wat gebeurde er op 20 juli 1969?", "Apollo 11 landde op de maan", "De Berlijnse muur viel", "Het legendarische festival Woodstock werd gehouden", "A"));
            Questions.Add(new Question("Welke taal heeft de meeste woorden?", "Spaans", "Russisch", "Engels", "C"));
            Questions.Add(new Question("Wat is het meest gestreamde album op Spotify?", "Drake - Certified Lover Boy", "Ed Sheeran - Shape of You", "Billie Eilish - Guitar Songs", "B"));
            Questions.Add(new Question("Hoeveel toetsen heeft een klassieke piano?", "52", "66", "88", "C"));
            Questions.Add(new Question("Welke Duitse coureur heeft de meeste Formule 1-kampioenschappen gewonnen?", "Michael Schumacher", "Max Verstappen", "Lewis Hamilton", "A"));
            Questions.Add(new Question("Wanneer werd Netflix opgericht?", "1997", "2001", "2009", "A"));
            Questions.Add(new Question("Wat was de meest bekeken serie op Netflix in 2019?", "Squid game", "Stranger Things", "Walking Dead", "B"));
            Questions.Add(new Question("Wat is Disney's eerste film?", "Assepoester", "Doornroosje", "Sneeuwwitje", "C"));
            Questions.Add(new Question("Welke achternaam komt in Nederland het meest voor?", "De Jong", "Janssen", "De Vries", "C"));
            Questions.Add(new Question("Bij welke provincie hoort het waddeneiland Ameland?", "Noord-Holland", "Friesland", "Groningen", "B"));
            Questions.Add(new Question("Wat is de hardste steen op aarde?", "Diamant", "Robijn", "Opaal", "A"));
            Questions.Add(new Question("Wat was de naam van de man die als eerste een voet op de maan zette?", "Elon Musk", "Neil Armstrong", "Buddy Vedder", "B"));
            Questions.Add(new Question("Waar staat het getal 3.14 voor?", "Delta", "Pi", "Alfa", "B"));
            Questions.Add(new Question("Welke letter staat voor 1000?", "G", "K", "Z", "B"));
            Questions.Add(new Question("In welke maateenheid wordt een beeldscherm aangeduid?", "Diameter", "Feet", "Inch", "C"));
            Questions.Add(new Question("Welk dier komt daar uit de spreekwoordelijke mouw?", "slang", "aap", "paard", "B"));
            Questions.Add(new Question("Welke twee docenten hebben dezelfde achternaam?", "Joost & Michel", "Kitty & Vincent", "Joep & Fedde", "C"));
            Questions.Add(new Question("Hoeveel toetsen zitten er op een qwerty toetsenbord met numeriek gedeelte?", "105", "104", "101", "B"));
            Questions.Add(new Question("Voordat onze school Curio heette hadden we een andere naam. Welke naam?", "ROC West-Brabant", "Radevliet College", "Zomius College", "A"));
            Questions.Add(new Question("Hoeveel studenten hebben zich dit jaar opgegeven voor het introkamp?", "82", "86", "91", "A"));
            Questions.Add(new Question("Wat is de naam van de manager van onze opleiding?", "Wiro Verdiesen", "George Veermans", "Corne Wagtmans", "B"));
            Questions.Add(new Question("Los op: als 1=2, 3=18, 5=50, 4=32, wat is dan 6?", "72", "84", "96", "A"));
            Questions.Add(new Question("Piloot Bart gaat voor een lange vlucht richting het zuiden. Na een poosje pakt hij een bocht van 90 graden naar links en daarna een bocht van 45 graden naar links. In welke richting is Bart nu aan het vliegen?", "Zuid-Oost", "Noord-West", "Noord-Oost", "C"));
            Questions.Add(new Question("Hoeveel strepen staan er op de Amerikaanse vlag?", "10", "13", "16", "B"));
            Questions.Add(new Question("Welke programmeertaal wordt hier omschreven? Een multi-inzetbare gecompileerde taal ontwikkeld door Bjarne Stroustrup in 1983. Het heeft de ontwikkeling van veel andere talen beinvloed.", "C", "C++", "C#", "B"));

            Questions.Add(new Question("Wat is de hoofdstad van Nederland?", "", "", "", "Amsterdam"));
            Questions.Add(new Question("Hoeveel dagen heeft een week?", "", "", "", "7"));
        }
    }
}
