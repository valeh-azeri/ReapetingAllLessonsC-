using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskForLogs.Enums;

namespace TaskForLogs
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DayteOfBirth { get; set; }
        public GenderEnum Gender { get; set; }
        public string JobDetails { get; set; }
        public string ImagePath { get; set; }
        public string CvPath { get; set; }

        public Employee(string name, string surname, DateTime dayteOfBirth, GenderEnum gender, string jobDetail)
        {
            Id = VirtualDatabase.EmplayeeIdentity;
            Name = name;
            Surname = surname;
            DayteOfBirth = dayteOfBirth;
            JobDetails = jobDetail;
            Gender = gender;

            VirtualDatabase.EmplayeeIdentity += 1; 
        }
    }
}
