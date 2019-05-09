using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PracticaMVVM.ViewModel
{
    public class MainViewModel
    {
        public LoginViewModel Login
        {
            get;
            set;
        }

        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
    }


}
