using System.Net.Http;
namespace MauiHttpBuilder;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	void test()
	{
		try
		{

		var h = new HttpClientHandler();
		label.Text = h.SupportsAutomaticDecompression
			? "MAUI supports automatic decompression"
			: "MAUI doesn't support automatic decompression";

		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			label.Text = $"{e.Message} {e.Source} {e.StackTrace}";
		}
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		test();
	}
}

