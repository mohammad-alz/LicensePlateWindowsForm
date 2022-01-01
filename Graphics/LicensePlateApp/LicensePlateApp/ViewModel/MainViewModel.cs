using LicensePlateApp.ViewModel.Commands;
using LicensePlateSDK;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing;
using System.Windows;

namespace LicensePlateApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string _fileName = "";
        string _result = "";
        public string FileName { get { return _fileName; } 
            set 
            { 
                _fileName = value;
                OnPropertyChanged(nameof(FileName));
            } 
        }

        public string Result { get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public BrowseCommand BrowseCmd { get; set; }
        public ProcessCommand ProcessCmd { get; set; }

        public MainViewModel()
        {
            BrowseCmd = new BrowseCommand(this);
            ProcessCmd = new ProcessCommand(this);

            if (!LicensePlate.IsActivated())
            {
                MessageBox.Show("Activate Yours License And Try Again!", "Error");
                Application.Current.Shutdown();
            }

            try
            {
                LicensePlate.Initialize();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                Application.Current.Shutdown();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Browse()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files *.*|*.*";
            if(openFileDialog.ShowDialog() == true)
            {
                FileName = openFileDialog.FileName;
            }
        }


        public void Process()
        {
            try
            {
                Result = LicensePlate.Predict(FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
