using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MauiCollectionView.Models
{
    public class Bot : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private double _height;
        public double Height
        {
            get => _height;
            set
            {
                _height = value;
                RaiseOnPropertyChanged();
            }
        }

        private double _width;
        public double Width
        {
            get => _width;
            set
            {
                _width = value;
                RaiseOnPropertyChanged();
            }
        }

        private ObservableCollection<Children> _childrens = new ObservableCollection<Children>();
        public ObservableCollection<Children> Childrens
        {
            get => _childrens;
            set
            {
                _childrens = value;
                RaiseOnPropertyChanged();
            }
        }
    }
}