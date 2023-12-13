using Microsoft.EntityFrameworkCore;

namespace OfficeLeagueAPI.Models
{
    public class PremierLeagueDbContext : DbContext
    {
        public PremierLeagueDbContext(DbContextOptions<PremierLeagueDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contestant> Contestants { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<OfficePremierLeagueScoreboard> Scoreboards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contestant>()
                .ToTable(nameof(Contestants));
            modelBuilder.Entity<Contestant>()
                .HasData(
                    new Contestant
                    {
                        ContestantId = 1,
                        FirstName = "Jaksa",
                        LastName = "Cukic",
                        Nickname = "Caksa",
                        IsAdmin = true,
                        Age = 25,
                    },
                    new Contestant
                    {
                        ContestantId = 2,
                        FirstName = "Gligorije",
                        LastName = "Petrovic",
                        Nickname = "Gypsy king",
                        IsAdmin = true,
                        Age = 23,
                    },
                    new Contestant
                    {
                        ContestantId = 3,
                        FirstName = "Srdjan",
                        LastName = "Todorovic",
                        Nickname = "Srdzan",
                        IsAdmin = true,
                        Age = 26,
                    }, new Contestant
                    {
                        ContestantId = 4,
                        FirstName = "Vuk",
                        LastName = "Trifunovic",
                        Nickname = "Csni",
                        IsAdmin = true,
                        Age = 23,
                    }
                );

            modelBuilder.Entity<Discipline>()
                 .ToTable(nameof(Disciplines));
            modelBuilder.Entity<Discipline>()
                .HasData(
                    new Discipline
                    {
                        DisciplineId = 10,
                        Name = "3UP",
                        DailyLimit = 1,
                        Points = 1.5f,
                        Description = "3UP description"
                    },
                    new Discipline
                    {
                        DisciplineId = 11,
                        Name = "Footbal Dice",
                        DailyLimit = 1,
                        Points = 1.25f,
                        Description = "Football Dice description"
                    },
                     new Discipline
                     {
                         DisciplineId = 12,
                         Name = "Uno",
                         DailyLimit = 4,
                         Points = 1f,
                         Description = "Uno description"
                     },
                     new Discipline
                     {
                         DisciplineId = 13,
                         Name = "Darts",
                         DailyLimit = 1,
                         Points = 1f,
                         Description = "Darts description"
                     }
                );
        }
    }
}
