using Lab3.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            BindingContext = new MainPageViewModel(JsonParser.ParseJson()) { Navigation = this.Navigation };
        }
    }
}