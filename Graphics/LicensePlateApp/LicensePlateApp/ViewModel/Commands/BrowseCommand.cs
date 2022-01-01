using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LicensePlateApp.ViewModel.Commands
{
    public class BrowseCommand : ICommand
    {
        MainViewModel mainViewModel;
        public BrowseCommand(MainViewModel viewModel)
        {
            mainViewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainViewModel.Browse();
        }
    }
}
