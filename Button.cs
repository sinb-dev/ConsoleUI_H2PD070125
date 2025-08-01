namespace ConsoleUI;
public class Button : UIElement
{
    public string Content = "";
    public Button()
    {

    }
    public Button(string content)
    {
        Content = content;
    }

    public override (int Width, int Height) GetSize()
    {
        return (Content.Length, 1);
    }

    public override void Render()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(Content);
    }
} //Button.cs