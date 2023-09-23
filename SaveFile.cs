using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{
    static public class JSONSerialize:I
    {

        public static string _usersList { get; } = "user.json";
        public static string _vacanciesList { get; } = "vacancies.json";
        public static string _cvList { get; } = "cv.json";




        public static void Login(string username, string password)
        {

        }

        public static void Register(Human human)
        {

        }
        public static void ChangePassword(Human human)
        {

        }
        public static void GetAllVacancies()
        {

        }
        public static void GetVacancyWithKeywords(string[]? keywords)
        {

        }
        public static void GetVacancyWithId(int id)
        {

        }
        public static void DeleteVacancy(int id)
        {

        }
        public static void AddCv(int userId)
        {

        }   
        public static void DeleteCv(int userId)
        {

        }


    }

}
