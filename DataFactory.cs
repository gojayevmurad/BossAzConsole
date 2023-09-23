using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAzConsole
{

    interface IDatabse
    {
        public string? Name { get; set; }

        void Register(Human user);
        void ChangePassword(Human user);
        void GetAllVacancies();
        void GetVacancyWithKeywords(string[]? keywords);
        void GetVacancyWithId(int vacancyId);
        void DeleteVacancy(int vacancyId);
        void AddCv(int userId);
        void DeleteCv(int userId);

    }

    internal class DataFactory
    {
        private readonly IDatabse _database;

        public DataFactory(IDatabse database)
        {
            _database = database;
        }

        void Register(Human user)
        {

        }

        void ChangePassword(Human user)
        {

        }

        void GetAllVacancies()
        {

        }

        void GetVacancyWithKeywords(string[]? keywords)
        {

        }

        void GetVacancyWithId(int vacancyId)
        {

        }

        void DeleteVacancy(int vacancyId)
        {

        }

        void AddCv(int userId)
        {

        }

        void DeleteCv(int userId)
        {

        }






    }
}
