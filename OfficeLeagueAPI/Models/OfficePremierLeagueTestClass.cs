namespace OfficeLeagueAPI.Models
{
    public class OfficePremierLeagueTestClass
    {
        public OfficePremierLeagueScoreboard[] Scoreboard { get; set; }

        public Contestant[] Contestant { get; set; }

        public Discipline[] Discipline { get; set; }



        private static List<OfficePremierLeagueScoreboard> _data = new()
    {
        new OfficePremierLeagueScoreboard
        {
                ScoreboardId = 1,
                ContestantId = 10,
                DisciplineId = 100,
                TimeDisciplineStarted = DateTime.Now,
                TimeDisciplineFinished= DateTime.Now,
                DateDisciplinePlayed = 20231511
        },
        new OfficePremierLeagueScoreboard
        {
                ScoreboardId = 2,
                ContestantId = 10,
                DisciplineId = 200,
                TimeDisciplineStarted = DateTime.Now,
                TimeDisciplineFinished= DateTime.Now,
                DateDisciplinePlayed = 20231511
        }
    };

        public static List<OfficePremierLeagueScoreboard> GetAllScores()
        {
            return _data;
        }

        public OfficePremierLeagueScoreboard? GetSpecificScore(int id)
        {

            var result = _data.SingleOrDefault(score => score.ScoreboardId == id);

            return result;
        }

        public bool CreateScore(OfficePremierLeagueScoreboard newScore)
        {
            if (newScore is null)
                return false;

            _data.Add(newScore);

            return true;
        }

        public bool UpdateScore(OfficePremierLeagueScoreboard updatedScore)
        {
            if (updatedScore is null)
                return false;

            var scoreIndex = _data.FindIndex(score => score.ScoreboardId == updatedScore.ScoreboardId);

            if (scoreIndex == -1)
                return false;

            _data[scoreIndex] = updatedScore;

            return true;
        }

        public static void RemoveScore(int scoreId)
        {
            _data = _data.FindAll(score => score.ScoreboardId != scoreId).ToList();
        }
    }
}
