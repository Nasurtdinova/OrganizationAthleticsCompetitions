using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationAthleticsCompetitions
{
    public class DataAccess
    {
        public static List<User> GetUsers()
        {
            return new List<User>(Connection.connection.User.ToList());
        }

        public static List<Team> GetTeams()
        {
            return new List<Team>(Connection.connection.Team.ToList());
        }

        public static List<Sportsman> GetSportsmans()
        {
            return new List<Sportsman>(Connection.connection.Sportsman.ToList());
        }

        public static List<ProgramCompetition> GetProgramsInCompetition(Competition com)
        {
            return new List<ProgramCompetition>(Connection.connection.ProgramCompetition.Where(a=>a.IdCompetition == com.Id).ToList());
        }

        public static List<Competition> GetCompetitions()
        {
            return new List<Competition>(Connection.connection.Competition.ToList());
        }

        public static List<Sportsman> GetSportmansInGenderAndTrainer(string gender)
        {
            return new List<Sportsman>(Connection.connection.Sportsman.Where(a=>a.Gender == gender && GetTrainersInTeam(a.Team).Where(b=>b.IdTrainer == CurrentUser.trainer.Id).Count() > 0) );
        }

        public static List<City> GetCities()
        {
            return new List<City>(Connection.connection.City.ToList());
        }

        public static List<Sportsman> GetSportsmansInTeam(Team team)
        {
            return new List<Sportsman>(Connection.connection.Sportsman.Where(a => a.IdTeam == team.Id).ToList());
        }


        public static List<Trainer_Team> GetTrainersInTeam(Team team)
        {
            return new List<Trainer_Team>(Connection.connection.Trainer_Team.Where(a => a.IdTeam == team.Id).ToList());
        }

        public static List<Trainer> GetTrainers()
        {
            return new List<Trainer>(Connection.connection.Trainer.ToList());
        }

        public static int IsCorrectUser(string email, string password)
        {
            var admin = from usrs in GetUsers()
                        where email == usrs.Login && password == usrs.Password && usrs.IdRole == 1
                        select usrs;

            var trainer = from usrs in GetUsers()
                          where email == usrs.Login && password == usrs.Password && usrs.IdRole == 2
                          select usrs;

            var sponsor = from usrs in GetUsers()
                          where email == usrs.Login && password == usrs.Password && usrs.IdRole == 3
                          select usrs;

            if (trainer.Count() == 1)
            {
                CurrentUser.user = trainer.FirstOrDefault();
                CurrentUser.trainer = GetSponsor(CurrentUser.user.Id);
                return 2;
            }
            else if (admin.Count() == 1)
            {
                CurrentUser.user = admin.FirstOrDefault();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static Trainer GetSponsor(int idUser)
        {
            return GetTrainers().Where(t => t.IdUser == idUser).FirstOrDefault();
        }
    }
}
