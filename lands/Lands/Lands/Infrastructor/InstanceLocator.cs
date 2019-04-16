using System;
using System.Collections.Generic;
using System.Text;

namespace Lands.Infrastructor
{

    using ViewModels;
   public class InstanceLocator
    {
        #region  properties
        public MainViewModel Main
        { get; set; }
        #endregion
        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
