using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMWpfTest.Models
{
    class TestModel : BindableBase
    {
        private String _strTemp;

        public String strTemp
        {
            get { return _strTemp; }
            set { SetProperty(ref _strTemp, value); }
        }
    }
}
