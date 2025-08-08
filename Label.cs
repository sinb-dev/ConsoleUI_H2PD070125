using System.Diagnostics.Contracts;

namespace ConsoleUI;

public class Label : UIElement
{
    public string Content = "";
    int _width = 0;
    public Label()
    {

    }
    public Label(string content)
    {
        Content = content;
    }
    public Label(string content, int width)
    {
        Content = content;
        _width = width;
    }

    public override (int Width, int Height) GetSize()
    {
        string[] lines = Content.Split("\n");
        int height = lines.Length;
        int width = 0;
        foreach (string line in lines) 
        {
            if (line.Length > width)
            {
                width = line.Length;
            }
        }
        return (width, height);
    }

    public override void Render()
    {
        string content = Content;
        if (content.Length < _width)
            content = content.PadRight(_width);
        
        Console.Write(content);
    }
    public override void Render(int maxWidth, int maxHeight)
    {
        string content = Content;
        if (content.Length > maxWidth) 
        {
            content = content.Substring(0, maxWidth-3) + "...";
        }

        Console.Write(content);
    }
}