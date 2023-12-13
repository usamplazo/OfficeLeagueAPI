using System.ComponentModel.DataAnnotations;

namespace OfficeLeagueAPI.Models
{
    public class OfficePremierLeagueScoreboard
    {
        [Key]
        public int ScoreboardId { get; set; }

        [Required]
        public int ContestantId { get; set; }

        [Required]
        public int DisciplineId { get; set; }

        [Required]
        public DateTime TimeDisciplineStarted { get; set; }

        [Required]
        public DateTime TimeDisciplineFinished { get; set; }

        [Required]
        // int DateDisciplinePlayed for better performance in data quering
        // format: yyyyMMdd 
        public int DateDisciplinePlayed { get; set; }
    }
}
