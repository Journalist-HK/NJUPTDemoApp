using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NJUPTDemoApp.Core.Models;

namespace NJUPTDemoApp.Core.Services
{
    public static class StudentDataService
    {
        private static IEnumerable<Student> AllStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    StudentID = 994201,
                    CommonScore = 88.00,
                    MidScore = 75.50,
                    FinalScore = 66.00
                },
                new Student()
                {
                    StudentID = 994202,
                    CommonScore = 91.00,
                    MidScore = 79.50,
                    FinalScore = 76.00
                },
                new Student()
                {
                    StudentID = 994203,
                    CommonScore = 85.00,
                    MidScore = 75.00,
                    FinalScore = 77.00
                },
                new Student()
                {
                    StudentID = 994204,
                    CommonScore = 79.00,
                    MidScore = 82.00,
                    FinalScore = 80.50
                },
                new Student()
                {
                    StudentID = 994205,
                    CommonScore = 94.00,
                    MidScore = 83.50,
                    FinalScore = 81.50
                },
                new Student()
                {
                    StudentID = 994206,
                    CommonScore = 88.00,
                    MidScore = 69.00,
                    FinalScore = 68.00
                },
                new Student()
                {
                    StudentID = 994207,
                    CommonScore = 82.00,
                    MidScore = 77.00,
                    FinalScore = 71.00
                },
                new Student()
                {
                    StudentID = 994208,
                    CommonScore = 77.00,
                    MidScore = 57.00,
                    FinalScore = 58.00
                },
                new Student()
                {
                      StudentID = 994209,
                      CommonScore = 91.00,
                      MidScore = 88.00,
                      FinalScore = 86.00
                },
                new Student()
                {
                      StudentID = 994210,
                      CommonScore = 96.00,
                      MidScore = 89.00,
                      FinalScore = 90.00
                },
                new Student()
                {
                      StudentID = 994211,
                      CommonScore = 70.00,
                      MidScore = 45.50,
                      FinalScore = 50.00
                },
                new Student()
                {
                      StudentID = 994212,
                      CommonScore = 74.00,
                      MidScore = 65.00,
                      FinalScore = 66.00
                },
                new Student()
                {
                      StudentID = 994213,
                      CommonScore = 81.00,
                      MidScore = 71.00,
                      FinalScore = 76.00
                },
                new Student()
                {
                      StudentID = 994214,
                      CommonScore = 83.00,
                      MidScore = 75.00,
                      FinalScore = 77.00
                },
                new Student()
                {
                      StudentID = 994215,
                      CommonScore = 85.00,
                      MidScore = 78.00,
                      FinalScore = 79.00
                }
            };
        }

        public static async Task<IEnumerable<Student>> GetGridDataAsync()
        {
            await Task.CompletedTask;
            return AllStudents();
        }
    }
}
