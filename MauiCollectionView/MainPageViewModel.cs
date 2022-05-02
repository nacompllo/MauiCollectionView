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
            for (var i = 0; i < 5; i++)
            {
                Bots.Add(new Bot
                {
                    Name = $"Bot {i}",
                    Width = 100,
                    Height = 100
                });
            }

            for (var i = 0; i < Bots.Count; i++)
            {
                var rnd = new Random();
                var number = rnd.Next(5, 15);
                for (var j = 0; j < number; j++)
                {
                    Bots[i].Childrens.Add(new Children
                    {
                        Name = $"Children {j}"
                    });
                }
            }
        }
    }
}