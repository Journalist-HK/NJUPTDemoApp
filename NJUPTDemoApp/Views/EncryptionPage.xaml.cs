using System;

using NJUPTDemoApp.ViewModels;
using NJUPTDemoApp.Helpers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NJUPTDemoApp.Views
{
    public sealed partial class EncryptionPage : Page
    {
        public EncryptionViewModel ViewModel { get; } = new EncryptionViewModel();

        public EncryptionPage()
        {
            InitializeComponent();
        }

        private void ButtonEncrypt_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxUnencrypted.Text != "" && TextBoxKey.Text != "")
            {
                TextBoxEncrypted.Text = Encryption.Encrypt(TextBoxUnencrypted.Text, TextBoxKey.Text);
            }
        }

        private void ButtonDecrypt_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxEncrypted.Text != "" && TextBoxKey.Text != "")
            {
                TextBoxUnencrypted.Text = Encryption.Decrypt(TextBoxEncrypted.Text, TextBoxKey.Text);
            }
        }
    }
}
