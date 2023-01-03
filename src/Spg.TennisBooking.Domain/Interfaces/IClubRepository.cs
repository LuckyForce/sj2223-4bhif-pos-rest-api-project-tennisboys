using Spg.TennisBooking.Domain.Model;

namespace Spg.TennisBooking.Domain.Interfaces
{
    public interface IClubRepository
    {
        Club? GetById(int id);
        Club? GetByLink(string link);
        bool Update(Club club);
        bool Delete(Club club);
    }
}
