using System;
using F23.StringSimilarity;
using NJUPTDemoApp.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NJUPTDemoApp.Views
{
    public sealed partial class TypingTestPage : Page
    {
        public TypingTestViewModel ViewModel { get; } = new TypingTestViewModel();

        public TypingTestPage()
        {
            InitializeComponent();
        }

        private void ButtonGenerate_Click(object sender, RoutedEventArgs e)
        {
            TextBoxRandom.Text = TypingTestViewModel.RandomRandomString();
        }

        private void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxAccuracy.Text = "";
            if (TextBoxRandom.Text != "" && TextBoxInput.Text != "")
            {
                var cosine = new Cosine(2);

                // For cosine similarity I need the profile of strings
                var profile1 = cosine.GetProfile(TextBoxRandom.Text);
                var profile2 = cosine.GetProfile(TextBoxInput.Text);

                // Prints 0.516185
                TextBoxAccuracy.Text = string.Format("{0:P2}", cosine.Similarity(profile1, profile2));
            }
        }
    }
}
