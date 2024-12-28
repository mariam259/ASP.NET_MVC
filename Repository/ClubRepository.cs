using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvc.Data;
using mvc.Interfaces;
using mvc.Models;

namespace mvc.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDBContext _context;

        public ClubRepository(ApplicationDBContext context)
        {
            _context = context;

        }

        public bool Add(Club club)
        {
            _context.Add(club); //this Add function generate the sql query for adding a club to DB
            return Save();  //when we implement the save function it the moment we truly run the query and save the club to the DB
        }

        public bool Delete(Club club)
        {
            _context.Remove(club);
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAlls()
        {
            return await _context.Clubs.ToListAsync();
        }

        public async Task<Club> GetByIdAsync(int id)
        {
            return await _context.Clubs.Include(i => i.Address).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<IEnumerable<Club>> GetClubByCity(string city)
        {
            return await _context.Clubs.Where(c => c.Address.City.Contains(city)).ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved >= 0 ? true : false;
        }

        public bool Update(Club club)
        {
            _context.Update(club);
            return Save();
        }
    }
}