namespace MAUI_Test1;

public partial class Calvulatorxaml : ContentPage
{
	public Calvulatorxaml()
	{
		InitializeComponent();

	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        string Name = uName.Text;
        string Password = uPass.Text;
        DisplayAlert("Named is", Name, "OK");
        DisplayAlert("Password is", Password, "OK");
    }
}