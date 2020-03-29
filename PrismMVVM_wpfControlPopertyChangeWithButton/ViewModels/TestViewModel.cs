using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using PrismMVVM_wpfControlPopertyChangeWithButton.Models;
using System.Windows.Input;
using Prism.Commands;

namespace PrismMVVM_wpfControlPopertyChangeWithButton.ViewModels
{
    class TestViewModel : BindableBase
    {
        private TestModel testModel;
        public TestModel TestModel
        {
            get { return testModel; }
            set { SetProperty(ref testModel, value); }
        }
        public ICommand ShowCommand { get; private set; }
        public ICommand HideCommand { get; private set; }

        public TestViewModel()
        {
            testModel = new TestModel();

            ShowCommand = new DelegateCommand(ShowMethod);
            HideCommand = new DelegateCommand(HideMethod);
        }

        private void HideMethod()
        {
            //TestModel.MessageVisibilityJJW = Visibility.Hidden;
            testModel.MessageVisibilityJJW = Visibility.Hidden;
        }

        private void ShowMethod()
        {
            TestModel.MessageVisibilityJJW = Visibility.Visible;
        }
    }
}
