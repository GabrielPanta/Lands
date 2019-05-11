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
        #region Properties
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Constructer
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        } 
        #endregion
    }


}
