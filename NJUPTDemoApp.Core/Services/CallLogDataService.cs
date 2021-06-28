using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NJUPTDemoApp.Core.Models;

namespace NJUPTDemoApp.Core.Services
{
    // This class holds sample data used by some generated pages to show how they can be used.
    // TODO WTS: The following classes have been created to display sample data. Delete these files once your app is using real data.
    // 1. Services/SampleDataService.cs
    // 2. Models/SampleCompany.cs
    // 3. Models/SampleOrder.cs
    // 4. Models/SampleOrderDetail.cs
    public static class CallLogDataService
    {

        private static IEnumerable<CallLog> AllLogs()
        {
            return new List<CallLog>()
            {
                new CallLog()
                {
                    SourceRegion = "025",
                    SourcePhone = "3491234",
                    DestinationRegion = "025",
                    DestinationPhone = "5319971",
                    Time = 70
                }
            };
        }


        // Remove this once your grid page is displaying real data.
        public static async Task<IEnumerable<CallLog>> GetGridDataAsync()
        {
            await Task.CompletedTask;
            return AllLogs();
        }
    }
}
