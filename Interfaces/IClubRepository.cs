using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Models;

namespace mvc.Interfaces
{
    public interface IClubRepository
    {
        //Task class is used to make the method asynchronous
        Task<IEnumerable<Club>> GetAlls();
        Task<Club> GetByIdAsync(int id);
        Task<IEnumerable<Club>> GetClubByCity(string city);

        //check for crud operations 
        bool Add(Club club);
        bool Update(Club club);
        bool Delete(Club club);
        bool Save();

    }
}