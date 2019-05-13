using GalaSoft.MvvmLight.Command;
using PracticaMVVM.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace PracticaMVVM.ViewModel
{
   public class LoginViewModel: BaseViewModel
    {

        #region Atributes
        private string Email;
        private string Password;
        private bool isEnabled;
        #endregion

        #region Properties
        public string email
        {
            get
            {
                return this.Email;
            }
            set
            {
                SetValue(ref this.Email, value);
            }
        }
        public string password
        {
            get
            {
                return this.Password;
            }

            set
            {
                SetValue(ref this.Password, value);
            }
        }
        public ICommand Login { get { return new RelayCommand(ValidarDatos); } }
        public bool IsEnabled {
            get
            {
                return this.isEnabled;
            }   

            set
            {
                SetValue(ref this.isEnabled, value);
            }
        }
        #endregion

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
            this.IsEnabled = false;

            if (this.email != "gabo" || this.password != "123")
            {
                this.IsEnabled = true;
                await App.Current.MainPage.DisplayAlert("Error", "Email o Contraseña Incorrecta", "Aceptar");
                this.password = string.Empty;
                return;
            }
            this.IsEnabled = true;

            this.email = string.Empty;
            this.password = string.Empty;

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());

        }

        #region Constructer
        public LoginViewModel()
        {
            this.isEnabled = true;
            this.email = "gabo";
            this.password = "123";
        } 
        #endregion
    }
}
