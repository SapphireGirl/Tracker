using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tracker.Models
{
    public static class DataFactory
    {
        public static IEnumerable<Resume> GetResumes()
        {
            return new List<Resume>
            {
                new Resume() {ResumeId = 1, FirstName = "Justine", LastName = "Alires", Email = "justinealires@outlook.com"},
                new Resume() {ResumeId = 2, FirstName = "Alicia", LastName = "Keys", Email = "justinealires@outlook.com"},
                new Resume() {ResumeId = 3, FirstName = "Kathy", LastName = "Dalton", Email = "justinealires@outlook.com"},
                new Resume() {ResumeId = 4, FirstName = "Janine", LastName = "Alires", Email = "justinealires@outlook.com"}

            };
        }

        public static IEnumerable<Skillset> GetSkillset()
        {
            return new List<Skillset>
            {
                new Skillset() {SkillsetId=1,UserName = "Justine", SkillName = ".NET", NoOfYears_Months = "5 years"},
                new Skillset() {SkillsetId=2,UserName = "Justine", SkillName = "C#", NoOfYears_Months = "5 years"},
                new Skillset() {SkillsetId=3,UserName = "Justine", SkillName = "MVC", NoOfYears_Months = "5 years"},
                new Skillset() {SkillsetId=4 ,UserName = "Justine", SkillName = "Entity Framework", NoOfYears_Months = "5 years"},


            };
        }
    }
}