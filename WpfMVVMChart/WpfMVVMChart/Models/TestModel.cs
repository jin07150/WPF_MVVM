using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMChart.Models
{
    class TestModel : BindableBase
    {
        private List<Keyvalue> _DataList;
        public List<Keyvalue> DataList
        {
            get { return _DataList; }
            set { SetProperty(ref _DataList, value); }
        }
    }

    class Keyvalue : BindableBase
    {
        private string _key;
        public string Key
        {
            get { return _key; }
            set { SetProperty(ref _key, value); }
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set { SetProperty(ref _value, value); }
        }
    }
}
