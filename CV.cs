using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;

namespace BossAzConsole
{

    enum LanguageLevels
    {
        Beginner = 1,
        Elementary,
        Intermediate,
        UpperIntermediate,
        Advanced,
        Proficient
    }

    class Experience
    {
        public string? CompanyName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


        public void Show()
        {
            Console.WriteLine($"Company: {CompanyName}({Start}-{End}) ");
        }

    }

    class ForeignLanguage
    {
        public string? LanguageName { get; set; }
        public string? LanguageLevel { get; set; }

        public ForeignLanguage(string? languageName, string? languageLevel)
        {
            LanguageName = languageName;
            LanguageLevel = languageLevel;
        }

        public void Show()
        {
            Console.WriteLine($"{LanguageName}({LanguageLevel})");
        }
        
    }

    internal class CV
    {
        public string? Speciality { get; set; }
        public string? School { get; set; }
        public string? UniversityScore { get; set; }
        public string[]? Skills { get; set; }
        public Experience[]? Experiences { get; set; }
        public bool HaveHonour { get; set; }
        public string? GithubUsername { get; set; }
        public string? LinkedinUsername { get; set; }
        public ForeignLanguage[] ForeignLanguages { get; set; }

        public CV(string? speciality, string? school, string? universityScore, string[]? skills, Experience[]? experiences, bool haveHonour, string? githubUsername, string? linkedinUsername, ForeignLanguage[] foreignLanguages)
        {
            Speciality = speciality;
            School = school;
            UniversityScore = universityScore;
            Skills = skills;
            Experiences = experiences;
            HaveHonour = haveHonour;
            GithubUsername = githubUsername;
            LinkedinUsername = linkedinUsername;
            ForeignLanguages = foreignLanguages;
        }
        

        public void Show()
        {
            Console.WriteLine("---------CV---------");
            Console.WriteLine($"Speciality : {Speciality}");
            Console.WriteLine($"School : {School}");
            Console.WriteLine($"University Score : {UniversityScore}");
            Console.WriteLine("Foreign Language(s) : ");
            foreach (var item in ForeignLanguages)
            {
                item.Show();
            }
            Console.WriteLine("Skill(s) :");
            foreach (var skill in Skills)
            {
                Console.WriteLine($"- {skill}");
            }
            Console.WriteLine("Experience(s) :");
            foreach (Experience experience in Experiences)
            {
                experience.Show();
            }
            Console.WriteLine($"Have Honour : {(HaveHonour ? "Yes" : "No")}");
            Console.WriteLine($"Github Username : {GithubUsername}");
            Console.WriteLine($"Linkedin Username : {LinkedinUsername}");
            Console.WriteLine("--------------------");
        }

    }
}
