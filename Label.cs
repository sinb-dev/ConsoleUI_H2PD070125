namespace ConsoleUI;

public class Label
{
    public string Content = "";
    public Label()
    {

    }
    public Label(string content)
    {
        Content = content;
    }
    public void Render()
    {
        Console.Write(Content);
    }
}