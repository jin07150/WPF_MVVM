using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace WPF_MVVM_Without_Prism.ViewModels
{
    class MainWindowViewModel
    {
        private ICommand m_ButtonCommand;
        public ICommand ButtonCommand
        {
            get { return m_ButtonCommand; }
            set { m_ButtonCommand = value; }
        }
        public MainWindowViewModel()
        {
            ButtonCommand = new RelayCommand(new Action<object>(ShowMessage));
        }
        public void ShowMessage(object obj)
        {
            MessageBox.Show(obj.ToString());
        }
    }

    class RelayCommand : ICommand
    {
        private Action<object> action;

        public RelayCommand(Action<object> action)
        {
            this.action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter != null)
            {
                action(parameter);
            }
            else
            {
                action("Hello World");
            }
        }
    }
}
