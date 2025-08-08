namespace ConsoleUI.Pages;

public class ListHostsPage : PageBase
{
    public ListHostsPage() : base("Hosts")
    {

    }
    protected override UIElement GetMain()
    {
        ColumnContainer main = new();
        main.AddChild(new Label("Here comes a list of host IPs"));
        main.AddChild(new Button("New host", openEditHostPage));
        return main;
    }
    void openEditHostPage()
    {
        Navigation.Open(new EditHostPage());
    }
} //Pages/ListHostsPage.cs