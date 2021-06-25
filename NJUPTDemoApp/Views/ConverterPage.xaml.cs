using System;

using NJUPTDemoApp.ViewModels;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NJUPTDemoApp.Views
{
    public sealed partial class ConverterPage : Page
    {
        private int? SourceBase { get; set; }
        public ConverterViewModel ViewModel { get; } = new ConverterViewModel();

        public ConverterPage()
        {
            InitializeComponent();
        }
        private void Base_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = sender as RadioButton;
            string radioButtonContent = radioButton?.Tag?.ToString();
            switch (radioButtonContent)
            {
                case "dec":
                    SourceBase = 10;
                    break;
                case "hex":
                    SourceBase = 16;
                    break;
                case "bin":
                    SourceBase = 2;
                    break;
                case "oct":
                    SourceBase = 8;
                    break;
            }
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            long textDec;
            switch (SourceBase)
            {
                case 10:
                    if (TextBoxDec.Text != "")
                    {
                        textDec = Convert.ToInt64(TextBoxDec.Text);
                        TextBoxBin.Text = Convert.ToString(textDec, 2);
                        TextBoxOct.Text = Convert.ToString(textDec, 8);
                        TextBoxHex.Text = Convert.ToString(textDec, 16).ToUpper();
                    }
                    break;
                case 16:
                    if (TextBoxHex.Text != "")
                    {
                        textDec = Convert.ToInt64(TextBoxHex.Text, 16);
                        TextBoxBin.Text = Convert.ToString(textDec, 2);
                        TextBoxOct.Text = Convert.ToString(textDec, 8);
                        TextBoxDec.Text = textDec.ToString();
                    }
                    break;
                case 2:
                    if (TextBoxBin.Text != "")
                    {
                        textDec = Convert.ToInt64(TextBoxBin.Text, 2);
                        TextBoxDec.Text = textDec.ToString();
                        TextBoxOct.Text = Convert.ToString(textDec, 8);
                        TextBoxHex.Text = Convert.ToString(textDec, 16).ToUpper();
                    }
                    break;
                case 8:
                    if (TextBoxOct.Text != "")
                    {
                        textDec = Convert.ToInt64(TextBoxOct.Text, 8);
                        TextBoxBin.Text = Convert.ToString(textDec, 2);
                        TextBoxDec.Text = textDec.ToString();
                        TextBoxHex.Text = Convert.ToString(textDec, 16).ToUpper();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
