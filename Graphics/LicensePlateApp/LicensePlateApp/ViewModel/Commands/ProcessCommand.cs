using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LicensePlateApp.ViewModel.Commands
{
    public class ProcessCommand : ICommand
    {
        MainViewModel mainViewModel;
        public ProcessCommand(MainViewModel viewmodel)
        {
            mainViewModel = viewmodel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainViewModel.Process();
        }
    }
}
