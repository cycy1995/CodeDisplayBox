using CodeDisplayBox.View;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;

namespace CodeDisplayBox.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            ImplementCommand();
        }

        #region ÃüÁî
        public ICommand InsertCodeCommand { get; set; }

        public ICommand BuildDepositoryCommand { get; set; }
        #endregion

        private void ImplementCommand()
        {
            InsertCodeCommand = new RelayCommand(() =>
            {
                InsertCodeWindow window = new InsertCodeWindow();
                InsertCodeViewModel model = new InsertCodeViewModel();
                window.DataContext = model;
                window.Owner = Application.Current.MainWindow;
                window.ShowDialog();
            });

            BuildDepositoryCommand = new RelayCommand(() => 
            {
                BuildDepositoryWindow window = new BuildDepositoryWindow();
                BuildDepositoryViewModel model = new BuildDepositoryViewModel();
                window.DataContext = model;
                window.Owner = Application.Current.MainWindow;
                window.ShowDialog();
            });
        }
    }
}