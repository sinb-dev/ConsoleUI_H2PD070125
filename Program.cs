// See https://aka.ms/new-console-template for more information
using ConsoleUI;

Console.CursorLeft = 0;
Console.CursorTop = 0;

ColumnContainer columnId = new();
columnId.AddChild(new Label("Id"));
columnId.AddChild(new Label("1"));
columnId.AddChild(new Label("200"));
ColumnContainer columnName = new();
columnName.AddChild(new Label("Name"));
columnName.AddChild(new Label("Konrad Sommer"));
columnName.AddChild(new Label("Anne Dam"));
RowContainer rowContainer = new();
rowContainer.AddChild(columnId);
rowContainer.AddChild(columnName);
rowContainer.Render();
Console.ReadKey();
