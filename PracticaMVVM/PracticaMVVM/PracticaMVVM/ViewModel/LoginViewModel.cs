using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PracticaMVVM.ViewModel
{
   public class LoginViewModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public ICommand Login { get { return new RelayCommand(ValidarDatos); } }
        public async void ValidarDatos()
        {
            if (string.IsNullOrEmpty(this.email))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un Email", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un Contraseña", "Aceptar");
                return;
            }

            if (this.email != "gabo" || this.password != "123")
            {
                await App.Current.MainPage.DisplayAlert("Error", "Email o Contraseña Incorrecta", "Aceptar");
                return;
            }
            await App.Current.MainPage.DisplayAlert("ok", "FUCK YEAHHH", "Aceptar");
            return;

        }
    }
}
