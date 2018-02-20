using System;
using System.ComponentModel;
using System.Windows.Input;
using Lab3.Model;
using Lab3.View;
using Xamarin.Forms;

namespace Lab3.ViewModel
{
    public class MainDetailPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public GamesModel Game { get; private set; }

        public ICommand LinkCommand { protected set; get; }

        public INavigation Navigation;


        public MainDetailPageViewModel(GamesModel gamesModel)
        {
            Game = gamesModel;
            LinkCommand = new Command(GoToLink);
        }

        private void GoToLink()
        {
            try
            {
                Navigation.PushAsync(new WebPage(Game.fullDescription.Link));
            }
            catch (Exception e)
            {
                new Exception(e.Message);
            }
        }
               
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
