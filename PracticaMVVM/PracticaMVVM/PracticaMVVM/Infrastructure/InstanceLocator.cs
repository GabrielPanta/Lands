using PracticaMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
//esto es una prueba de que todo esta bien
namespace PracticaMVVM.Infrastructure
{
   public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion
        #region Constructer
        public InstanceLocator()
        {
            Main = new MainViewModel();
        } 
        #endregion
    }

}
 