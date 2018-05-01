using System;
using System.Collections.Generic;
using D365ODataService.Models;

namespace D365ODataService.DataSource
{
    public class DemoDataSource
    {
        private static DemoDataSource _instance;

        /// <summary>
        /// Simgleton for the Demodatabase to prevent multiple instances in memory
        /// </summary>
        public static DemoDataSource Instance => _instance ?? (_instance = new DemoDataSource());

        public List<Complaint> Complaints { get; set; }

        private DemoDataSource()
        {
            Reset();
            Initialize();
        }

        private void Reset()
        {
            Complaints = new List<Complaint>();
        }

        private void Initialize()
        {
            Complaints.AddRange(new List<Complaint>
            {
                new Complaint
                {
                    Id = new Guid("3C57243C-711B-414F-9463-93E2FF71347D"),
                    Subject = "Complaint 1",
                    AccountNumber = "0815",
                    Description = "some text for complaint 1"
                },
                new Complaint
                {
                    Id = new Guid("9C4FC268-8AFE-4B17-BCB6-34DF5180A663"),
                    Subject = "Complaint 2",
                    AccountNumber = "0815",
                    Description = "some text for complaint 2"
                },
                new Complaint
                {
                    Id = new Guid("54871599-CE08-4591-A342-42EF1659C20C"),
                    Subject = "Complaint 3",
                    AccountNumber = "4711",
                    Description = "some text for complaint 3"
                },
                new Complaint
                {
                    Id = new Guid("561ABA25-2039-4394-B338-BF94F12AEDA2"),
                    Subject = "Complaint 4",
                    AccountNumber = "4711",
                    Description = "some text for complaint 4"
                },
                new Complaint
                {
                    Id = new Guid("A9AE7886-A82E-463D-95B4-0F034BA19592"),
                    Subject = "Complaint 5",
                    AccountNumber = "1234",
                    Description = "some text for complaint 5"
                },
                new Complaint
                {
                    Id = new Guid("E9545417-568B-4066-8B77-35A2BA6D781B"),
                    Subject = "Complaint 6",
                    AccountNumber = "2345",
                    Description = "some text for complaint 6"
                }
            });
        }
    }
}