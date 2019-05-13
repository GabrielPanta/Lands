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
        public LandsViewModel Lands
        {
            get;
            set;
        }

        #endregion

        #region Constructer
        public MainViewModel()
        {
            Instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel Instance;
        public static MainViewModel GetInstance()
        {
            if (Instance == null)
            {
                return new MainViewModel();
            }
            return Instance;
        }

        #endregion
    }


}
