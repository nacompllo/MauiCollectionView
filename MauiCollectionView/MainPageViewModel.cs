using MauiCollectionView.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiCollectionView
{
    public class MainPageViewModel
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public ICommand SelectFileCommand => new Command(async () => await SelectFile());

        private async Task<FileResult> SelectFile()
        {
            var options = new PickOptions
            {
                PickerTitle = "Please select an video",
                FileTypes = FilePickerFileType.Videos,
            };
            var file = await PickAndShow(options);
            return file;
        }

        private async Task<FileResult> PickAndShow(PickOptions options)
        {
            try
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var result = await FilePicker.PickAsync(options);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}