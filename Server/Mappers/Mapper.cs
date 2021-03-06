﻿
using System.Collections.Generic;
using System.Linq;
using Contracts;

namespace Mappers
{
    public static class Mapper
    {
        #region ToContracts

        #region ListMappers

        public static List<Company> ToContracts(this IEnumerable<Database_Entities.Company> companies)
        {
            var listUsers = companies.ToList();
            return listUsers.ConvertAll(x => new Company
            {
                Id = x.Id,
                Name = x.Name,
                Website = x.Website,
                Password = x.Password
            });
        }

        public static List<PersonalLetter> ToContracts(this IEnumerable<Database_Entities.PersonalLetter> personalLetters)
        {
            var listUsers = personalLetters.ToList();
            return listUsers.ConvertAll(x => new PersonalLetter
            {
                Id = x.Id,
                Company = x.Company.ToContract(),
                Description = x.Description,
                DownloadCount = x.DownloadCount,
            });
        }

        public static List<Admin> ToContracts(this IEnumerable<Database_Entities.Admin> admins)
        {
            var listUsers = admins.ToList();
            return listUsers.ConvertAll(x => new Admin
            {
                Id = x.Id,
                Email = x.Email,
                Firstname = x.Firstname,
                Lastname = x.Lastname,
                Password = x.Password
            });
        }

        public static List<Technician> ToContracts(this IEnumerable<Database_Entities.Technician> technicians)
        {
            var listUsers = technicians.ToList();
            return listUsers.ConvertAll(x => new Technician
            {
                Id = x.Id,
                Name = x.Name,
                Percentage = x.Percentage,
                Type = x.Type
            });
        }

        #endregion


        #region ObjectMappers



        public static Company ToContract(this Database_Entities.Company company)
        {
            return new Company
            {
                Name = company.Name,
                Id = company.Id,
                Website = company.Website,
                Password = company.Password
            };
        }

        public static PersonalLetter ToContract(this Database_Entities.PersonalLetter personalLetter)
        {
            return new PersonalLetter
            {
                Company = personalLetter.Company.ToContract(),
                Description = personalLetter.Description,
                Id = personalLetter.Id,
                DownloadCount = personalLetter.DownloadCount,
            };
        }

        public static Admin ToContract(this Database_Entities.Admin admin)
        {
            return new Admin
            {
                Email = admin.Email,
                Firstname = admin.Firstname,
                Id = admin.Id,
                Lastname = admin.Lastname,
                Password = admin.Password
            };
        }

        public static Technician ToContract(this Database_Entities.Technician technician)
        {
            return new Technician
            {
                Id = technician.Id,
                Name = technician.Name,
                Percentage = technician.Percentage,
                Type = technician.Type
            };
        }

        #endregion


        #endregion

        #region ToDatabaseEntities

        #region ListMappers



        public static List<Database_Entities.Company> ToDatabaseEntities(this IEnumerable<Company> companies)
        {
            var listUsers = companies.ToList();
            return listUsers.ConvertAll(x => new Database_Entities.Company
            {
                Website = x.Website,
                Id = x.Id,
                Name = x.Name,
                Password = x.Password
            });
        }

        public static List<Database_Entities.PersonalLetter> ToDatabaseEntities(this IEnumerable<PersonalLetter> personalLetters)
        {
            var listLetters = personalLetters.ToList();
            return listLetters.ConvertAll(x => new Database_Entities.PersonalLetter
            {
                Company = x.Company.ToDatabaseEntitie(),
                Description = x.Description,
                Id = x.Id,
                DownloadCount = x.DownloadCount,
            });
        }

        public static List<Database_Entities.Technician> ToDatabaseEntities(this IEnumerable<Technician> technicians)
        {
            var listLetters = technicians.ToList();
            return listLetters.ConvertAll(x => new Database_Entities.Technician
            {
                Id = x.Id,
                Name = x.Name,
                Percentage = x.Percentage,
                Type = x.Type
            });
        }

        #endregion

        #region ObjectMappers


        public static Database_Entities.Company ToDatabaseEntitie(this Company company)
        {
            return new Database_Entities.Company
            {
                Website = company.Website,
                Id = company.Id,
                Name = company.Name,
                Password = company.Password
            };
        }

        public static Database_Entities.PersonalLetter ToDatabaseEntitie(this PersonalLetter personalLetter)
        {
            return new Database_Entities.PersonalLetter
            {
                Company = personalLetter.Company.ToDatabaseEntitie(),
                Description = personalLetter.Description,
                Id = personalLetter.Id,
                DownloadCount = personalLetter.DownloadCount,
            };
        }

        public static Database_Entities.Admin ToDatabaseEntitie(this Admin admin)
        {
            return new Database_Entities.Admin
            {
                Email = admin.Email,
                Firstname = admin.Firstname,
                Id = admin.Id,
                Lastname = admin.Lastname,
                Password = admin.Password
            };
        }

        public static Database_Entities.Technician ToDatabaseEntitie(this Technician technician)
        {
            return new Database_Entities.Technician
            {
                Id = technician.Id,
                Name = technician.Name,
                Percentage = technician.Percentage,
                Type = technician.Type
            };
        }

        #endregion

        #endregion
    }
}
