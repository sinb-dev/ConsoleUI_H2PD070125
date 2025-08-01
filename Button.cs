namespace ConsoleUI;
public class Button
{
    public string Content = "";
    public Button()
    {

    }
    public Button(string content)
    {
        Content = content;
    }
    public void Render()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(Content);
    }
} //Button.cs