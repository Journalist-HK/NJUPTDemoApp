using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Microsoft.Toolkit.Mvvm.ComponentModel;

using NJUPTDemoApp.Core.Models;
using NJUPTDemoApp.Core.Services;

namespace NJUPTDemoApp.ViewModels
{
    public class CallLogDataGridViewModel : ObservableObject
    {
        public ObservableCollection<CallLog> Source { get; } = new ObservableCollection<CallLog>();

        public CallLogDataGridViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // Replace this with your actual data
            var data = await CallLogDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
