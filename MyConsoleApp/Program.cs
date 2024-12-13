string projectName = "ACME";
string path = @"c:\Exercise\";
string englishFolder = "";
string russianFolder = @"ru-RU\";
string englishMessage = "View English output";
string file = "data.txt";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"{englishMessage}:\n\t\t{path}{englishFolder}{projectName}\\{file}\n");
Console.WriteLine($"{russianMessage}:\n\t\t{path}{russianFolder}{projectName}\\{file}\n");