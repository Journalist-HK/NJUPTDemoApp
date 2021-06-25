using System;
using System.Collections.Generic;
using NJUPTDemoApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace NJUPTDemoApp.Views
{
    public sealed partial class ChartPage : Page
    {
        public ChartViewModel ViewModel { get; } = new ChartViewModel();

        // TODO WTS: Change the chart as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/radchart/getting-started
        public ChartPage()
        {
            InitializeComponent();
            a.ItemsSource = CreateData();
        }

        //protected override async void OnNavigatedTo(NavigationEventArgs e)
        //{
        //    base.OnNavigatedTo(e);

        //    await ViewModel.LoadDataAsync();
        //}
        public List<Data> CreateData()
        {
            List<Data> data = new List<Data>();
            data.Add(new Data() { Value = 6.67, Mark = "A" });
            data.Add(new Data() { Value = 33.33, Mark = "B" });
            data.Add(new Data() { Value = 40, Mark = "C" });
            data.Add(new Data() { Value = 13.33, Mark = "D" });
            data.Add(new Data() { Value = 6.67, Mark = "E" });

            return data;
        }

        public class Data
        {
            public double Value { get; set; }

            public string Mark { get; set; }
        }
    }
}
