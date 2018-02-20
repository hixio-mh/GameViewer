using Lab3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Lab3.View;

namespace Lab3.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<GamesModel> Games { get; private set; }

        private GamesModel selectedGame;

        public INavigation Navigation;
        
        
        public MainPageViewModel(Games games)
        {
            Games = games.games;
        }

        public GamesModel SelectedGame
        {
            get { return selectedGame; }
            set
            {
                if (selectedGame != value)
                {
                    GamesModel tempValue = value;
                    selectedGame = null;
                    OnPropertyChanged("SelectedGame");
                    try
                    {
                        Navigation.PushAsync(new DetailPage(tempValue));
                    }
                    catch(Exception e)
                    {
                        new Exception(e.Message);
                    }
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
