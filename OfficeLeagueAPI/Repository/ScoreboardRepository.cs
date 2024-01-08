using OfficeLeagueAPI.Models;
using OfficeLeagueAPI.UnitOfWork;

namespace OfficeLeagueAPI.Repository
{
    public class ScoreboardRepository : RepositoryBase<OfficePremierLeagueScoreboard>
    {
        public ScoreboardRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
