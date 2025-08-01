// See https://aka.ms/new-console-template for more information
using ConsoleUI;

Console.CursorLeft = 10;
Console.CursorTop = 10;
Label label = new Label("Hello Label");
label.Render();
new Button("Useless button").Render();
Console.ReadKey();