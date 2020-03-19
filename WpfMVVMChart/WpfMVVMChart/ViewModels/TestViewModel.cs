using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Media;
using WpfMVVMChart.Models;

namespace WpfMVVMChart.ViewModels
{
    class TestViewModel : BindableBase
    {
        private TestModel testModel;
        public TestModel TestModel
        {
            get { return testModel; }
            set { SetProperty(ref testModel, value); }
        }

        public TestViewModel()
        {
            testModel = new TestModel();



        }

        public TestViewModel(GroupBox GroupBoxDynamicChart)
        {
            List<Keyvalue> tempList = new List<Keyvalue>();
            tempList.Add(new Keyvalue() { Key = "Rs.100", Value = 50 });
            tempList.Add(new Keyvalue() { Key = "Rs.500", Value = 18 });
            tempList.Add(new Keyvalue() { Key = "Rs.1000", Value = 25 });
            tempList.Add(new Keyvalue() { Key = "Rs.2000", Value = 5 });

            testModel = new TestModel();
            testModel.DataList = tempList;

            // dynamic chart
            Chart dynamicChart = new Chart();
            ColumnSeries columnseries = new ColumnSeries();
            columnseries.ItemsSource = tempList;
            columnseries.DependentValuePath = "Value";
            columnseries.IndependentValuePath = "Key";
            dynamicChart.Series.Add(columnseries);
            dynamicChart.Background = Brushes.Cyan;
            GroupBoxDynamicChart.Content = dynamicChart;


        }
    }
}
