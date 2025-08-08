namespace ConsoleUI;
public class Button : ControlBase
{
    public string Content = "";
    int _width = 20;
    Action? _onClicked;
    public Button(string content, Action? onClicked=null, int width = 20)
    {
        Content = content;
        _onClicked = onClicked;
        _width = width;
    }
    public override (int Width, int Height) GetSize()
    {
        return (Content.Length, 1);
    }

    public override void HandleKeyInfo(ConsoleKeyInfo keyInfo)
    {
        switch (keyInfo.Key)
        {
            case ConsoleKey.Enter:
                _onClicked?.Invoke();
                break;
        }
    }

    public override void Render()
    {
        Render();
    }

    public override void Render(int maxWidth, int maxHeight)
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        string content = Content;
        if (content.Length > maxWidth) 
        {
            content = content.Substring(0, maxWidth-3) + "...";
        }
        else if (content.Length < _width)
        {
            //Align the button text in the middle of the button
            int spaceLeft = _width - content.Length;
            int padLeft = (int) Math.Round(spaceLeft*0.5) + content.Length;
            content = content.PadLeft(padLeft).PadRight(_width);
        }

        Console.Write(content);
    }
} //Button.cs