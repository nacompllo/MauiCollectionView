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

        private ObservableCollection<Panel> _panels = new ObservableCollection<Panel>();
        public ObservableCollection<Panel> Panels
        {
            get => _panels;
            set
            {
                _panels = value;
                RaiseOnPropertyChanged();
            }
        }

        private double _flexHeight = 200;
        public double FlexHeight
        {
            get => _flexHeight;
            set
            {
                _flexHeight = value;
                RaiseOnPropertyChanged();
            }
        }

        private double _flexWidth = 200;
        public double FlexWidth
        {
            get => _flexWidth;
            set
            {
                _flexWidth = value;
                RaiseOnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            for (var i = 0; i < 10; i++)
            {
                Panels.Add(new Panel
                {
                    Name = $"Panel {i}",
                    Width = 100,
                    Height = 100,
                    Blocks = new ObservableCollection<Block>()
                });

                var rnd = new Random();
                var blocksNumber = rnd.Next(1, 10);

                for (var j = 0; j < 5; j++)
                {
                    Panels.Last().Blocks.Add(new Block
                    {
                        Name = $"Block {j}",
                        Width = 100,
                        Height = 100
                    });
                }
            }
        }
    }
}