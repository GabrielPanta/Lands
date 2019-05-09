using PracticaMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaMVVM.Infrastructure
{
   public class InstanceLocator
    {
        public MainViewModel Main
        {
            get;
            set;
        }
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }

}
 