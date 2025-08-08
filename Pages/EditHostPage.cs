namespace ConsoleUI.Pages;

public class EditHostPage : PageBase
{
    //Declare controls on the class to prevent being reset every render
    TextBox txtHostName = new();
    TextBox txtIpAddress = new();
    public EditHostPage() : base("Edit host")
    {

    }
    protected override UIElement GetMain()
    {
        ColumnContainer main = new();
        main.AddChild(new Label("Here comes a form to edit a host with"));
        main.AddChild(new Label("Host name"));
        main.AddChild(txtHostName);
        main.AddChild(new Label("IP Address"));
        main.AddChild(txtIpAddress);
        main.AddChild(new Button("Go back", Navigation.Back));
        return main;
    }
} //Pages/EditHostPage.cs