using Quiz;




// tworzenie obiektu gry
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyświetlanie ekranu powitalnego
message.DisplayWelcomeScreen();

while(true)
{
    // losowanie pytania z aktualnej kategorii
    game.GetQuestion();

    // wyświetlamy pytanie graczowi i pobieramy jego odpowiedz
    int playerAnswer = game.CurrentQuestion.DisplayQuestion();

    // walidacja ospowiedzi gracza ...
    // w zmiennej correct przechowujemy informację czy gracz odpowiedział poprawnie
    bool correct = game.IsCorrectAnswer(playerAnswer);

    if (correct)
    {
        if (game.IsLastCategory())
        {
            // ostatnie pytanie
            message.FinalScreen();
            break;
        }
        else
        {
            message.GoodAnswer();
        }
    }
    else
    {
        message.QuizFail();
        break;
    }

    Console.WriteLine();
    Console.WriteLine(playerAnswer);
}


