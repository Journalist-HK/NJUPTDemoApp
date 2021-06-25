using System;

using NJUPTDemoApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace NJUPTDemoApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
