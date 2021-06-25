using System;

using NJUPTDemoApp.ViewModels;
using NJUPTDemoApp.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NJUPTDemoApp.Views
{
    public sealed partial class SortPage : Page
    {
        public SortViewModel ViewModel { get; } = new SortViewModel();

        public SortPage()
        {
            InitializeComponent();
        }
        int n = 0;
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "" || textbox2.Text == "")
            {
                XamlAttachingCoding.ShowMessage("No valid score");
            }

            else
            {
                if (XamlAttachingCoding.bolNum(textbox2.Text) == false)
                {
                    XamlAttachingCoding.ShowMessage("Invalid score");
                    textbox1.Text = "";
                    textbox2.Text = "";
                }

                else
                {
                    sc1[n].name = textbox1.Text;
                    sc1[n].sco = double.Parse(textbox2.Text);
                    n++;
                    XamlAttachingCoding.ShowMessage("Input succeed");
                    textbox1.Text = "";
                    textbox2.Text = "";
                }

            }

        }



        struct Score
        {
            public string name;
            public double sco;
        }

        Score[] sc1 = new Score[15];

        string OutGrade;
        public void BubbleDescend()
        {
            for (int i = 0; i < sc1.Length; i++)
            {
                for (int j = i; j < sc1.Length; j++)
                {
                    if (sc1[i].sco < sc1[j].sco)
                    {
                        Score temp = sc1[i];
                        sc1[i] = sc1[j];
                        sc1[j] = temp;
                    }
                }
            }


        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            BubbleDescend();

            for (int m = 0; m < sc1.Length; m++)
            {
                if (sc1[m].name == null)
                { }
                else
                { OutGrade = OutGrade + ($"学号：{sc1[m].name}    成绩：{sc1[m].sco}") + "\r\n"; }

            }

            textbox3.Text = OutGrade;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(sc1, 0, sc1.Length);
            OutGrade = null;
            textbox3.Text = "";
            XamlAttachingCoding.ShowMessage("清除成功");
        }
    }
}
