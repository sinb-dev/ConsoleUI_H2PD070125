namespace ConsoleUI;
public class GridContainer : ContainerBase
{
    public GridContainer()
    {

    }
    public void AddChild(UIElement child, int rowIndex, int colIndex)
    {

    }
    public override void Render()
    {
        ConsoleColor background = Console.BackgroundColor;
        ConsoleColor foreground = Console.ForegroundColor;
        
        
    }
    public override (int Width, int Height) GetSize()
    {
        
        return (0, 0);
    }
}