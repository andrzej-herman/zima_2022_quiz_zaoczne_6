using Quiz;




// tworzenie obiektu gry
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyświetlanie ekranu powitalnego
message.DisplayWelcomeScreen();

// losowanie pytania z aktualnej kategorii
game.GetQuestion();

// wyświetlamy pytanie graczowi i pobieramy jego odpowiedz
int playerAnswer = game.CurrentQuestion.DisplayQuestion();

// następne zajęcia => walidacja ospowiedzi gracza ...


Console.WriteLine();
Console.WriteLine(playerAnswer);