using Lab3.Model;
using Lab3.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
		public DetailPage (GamesModel model)
		{
			InitializeComponent ();
            BindingContext = new MainDetailPageViewModel(model) { Navigation = this.Navigation };
        }
	}
}