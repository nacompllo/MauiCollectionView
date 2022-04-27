using MauiCollectionView.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiCollectionView
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private ObservableCollection<Bot> _bots = new ObservableCollection<Bot>();
        public ObservableCollection<Bot> Bots
        {
            get => _bots;
            set
            {
                _bots = value;
                RaiseOnPropertyChanged();
            }
        }

        private Bot _selectedBot;
        public Bot SelectedBot
        {
            get => _selectedBot;
            set
            {
                _selectedBot = value;
                RaiseOnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            for (var i = 0; i < 10; i++)
            {
                Bots.Add(new Bot
                {
                    Name = $"Bot {i}",
                    Width = 100,
                    Height = 100
                });
            }
        }
    }
}