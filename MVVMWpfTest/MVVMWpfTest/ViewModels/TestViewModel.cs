using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMWpfTest.ViewModels
{
    class TestViewModel : BindableBase
    {
        private Models.TestModel testModel;

        public ICommand UpdateCommand { get; private set; }
        public ICommand ClearCommand { get; private set; }

        public Models.TestModel TestModel
        {
            get { return testModel; }
            set { SetProperty(ref testModel, value); }
        }

        public TestViewModel()
        {
            testModel = new Models.TestModel();
            testModel.strTemp = "Initial String ^^";
            UpdateCommand = new DelegateCommand(updateCommand);
            ClearCommand = new DelegateCommand(clearCommand);
        }

        private void clearCommand()
        {
            testModel.strTemp = "clear button clicked !!!";
        }

        private void updateCommand()
        {
            testModel.strTemp = "update button clicked !!!";
           
        }
    }
}
