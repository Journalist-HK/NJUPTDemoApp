using System;

using NJUPTDemoApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace NJUPTDemoApp.Views
{
    public sealed partial class CallUserDataGridPage : Page
    {
        public CallUserDataGridViewModel ViewModel { get; } = new CallUserDataGridViewModel();

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on CallUserDataGridPage.xaml.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public CallUserDataGridPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }

        private void btnOpen_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
