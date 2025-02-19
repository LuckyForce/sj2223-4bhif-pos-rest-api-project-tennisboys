using Microsoft.EntityFrameworkCore;
using Spg.TennisBooking.Domain.Interfaces;
using Spg.TennisBooking.Domain.Model;
using Spg.TennisBooking.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.TennisBooking.Repository.Repositories
{
    public class CourtRepository : ICourtRepository
    {
        private readonly TennisBookingContext _db;

        public CourtRepository(TennisBookingContext db)
        {
            _db = db;
        }

        public void Add(Court court)
        {
            _db.Courts.Add(court);
            _db.SaveChanges();
        }

        public void Delete(Court court)
        {
            _db.Courts.Remove(court);
            _db.SaveChanges();
        }

        public async Task<IEnumerable<Court>> GetAll(Club club)
        {
            return await _db.Courts.Where(c => c.ClubNavigation == club).ToListAsync();
        }

        public async Task<Court?> Get(int id)
        {
            return await _db.Courts.FindAsync(id);
        }

        public void Update(Court court)
        {
            _db.Courts.Update(court);
            _db.SaveChanges();
        }
    }
}
