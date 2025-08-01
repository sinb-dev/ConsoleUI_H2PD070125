namespace ConsoleUI;

public class Label : UIElement
{
    public string Content = "";
    public Label()
    {

    }
    public Label(string content)
    {
        Content = content;
    }
    public override void Render()
    {
        Console.Write(Content);
    }
}