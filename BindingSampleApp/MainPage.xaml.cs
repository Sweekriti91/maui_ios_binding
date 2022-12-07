using XMBindingLibrary;

namespace BindingSampleApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		// Binding Project code called here

		var utility = new XMUtilities();
		var result = utility.Hello("Developer");

		Console.WriteLine(result);
	}
}


