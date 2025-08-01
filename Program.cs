// See https://aka.ms/new-console-template for more information
using ConsoleUI;

// Console.CursorLeft = 0;
// Console.CursorTop = 0;

ColumnContainer columnId = new();
columnId.AddChild(new Label("Id"));
columnId.AddChild(new Label("1"));
columnId.AddChild(new Label("200"));
columnId.AddChild(new TextBox("Enter ID"));
ColumnContainer columnName = new();
columnName.AddChild(new Label("Name"));
columnName.AddChild(new Label("Konrad Sommer"));
columnName.AddChild(new Label("Anne Dam"));
columnId.AddChild(new TextBox("Enter Name"));
RowContainer rowContainer = new();
rowContainer.AddChild(columnId);
rowContainer.AddChild(columnName);


ConsoleKeyInfo keyInfo;
while (true)
{
    Console.CursorLeft = 0;
    Console.CursorTop = 0;
    Console.Clear();
    rowContainer.Render();

    keyInfo = Console.ReadKey();

    switch(keyInfo.Key)
    {
        case ConsoleKey.Escape:
            break;
        case ConsoleKey.Tab:
            if (keyInfo.Modifiers == ConsoleModifiers.Shift)
                ControlBase.PreviousControl();
            else
                ControlBase.NextControl();
            break;
        default:
            ControlBase? activeControl = ControlBase.GetActiveControl();
            activeControl?.HandleKeyInfo(keyInfo);
            break;
    }
}
//Program.cs

Console.ReadKey();
