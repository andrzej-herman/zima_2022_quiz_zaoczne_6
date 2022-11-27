using Quiz;

//for (int licznik = 102; licznik < 100; licznik++)
//{
//    Console.WriteLine(licznik);
//}

//foreach (var xxxx in names)
//{
//    Console.WriteLine(xxxx);
//}

//short x = 0;
//while (true)
//{
//    Console.WriteLine(x);
//    if (x == 100) break;
//}
















// tworzenie obiektu gry
var game = new Game();

// tworzenie obiektu typu Message
var message = new Message();

// wyświetlanie ekranu powitalnego
message.DisplayWelcomeScreen();

// losowanie pytania z aktualnej kategorii
game.GetQuestion();


Console.WriteLine(game.CurrentQuestion.Content);











Console.WriteLine();



