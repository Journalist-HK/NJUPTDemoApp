using System;
using System.Linq;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace NJUPTDemoApp.ViewModels
{
    public class TypingTestViewModel : ObservableObject
    {
        public TypingTestViewModel()
        {
        }

        private static Random random = new Random();
        private static Random randomLen = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomRandomString()
        {
            return RandomString(randomLen.Next(8, 25));
        }
    }
}
