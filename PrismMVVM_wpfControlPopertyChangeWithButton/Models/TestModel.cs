using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PrismMVVM_wpfControlPopertyChangeWithButton.Models
{
    class TestModel : BindableBase
    {
        private Visibility _MessageVisibilty;
        public Visibility MessageVisibilityJJW
        {
            get { return _MessageVisibilty; }
            set { SetProperty(ref _MessageVisibilty, value); }
        }
    }
}
