using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganizationAthleticsCompetitions.DataBase;

namespace OrganizationAthleticsCompetitions
{
    public class DataAccess
    {
        public static List<User> GetUsers()
        {
            return new List<User>(Connection.connection.User.ToList());
        }

        public static List<Sponsor> GetSponsors()
        {
            return new List<Sponsor>(Connection.connection.Sponsor.ToList());
        }

        public static bool IsTrueLogin(string login)
        {
            if (GetUsers().Where(a => a.Login == login).Count() > 0)
                return false;
            else
                return true;
        }

        public static List<SponsorTeam> GetSponsorTeams()
        {
            return new List<SponsorTeam>(Connection.connection.SponsorTeam.ToList());
        }

        public static List<Gender> GetGenders()
        {
            return new List<Gender>(Connection.connection.Gender.ToList());
        }

        public static List<Venue> GetVenues()
        {
            return new List<Venue>(Connection.connection.Venue.ToList());
        }

        public static List<CategoryCompetition> GetCategoryCompetitions()
        {
            return new List<CategoryCompetition>(Connection.connection.CategoryCompetition.ToList());
        }

        public static List<Team> GetTeams()
        {
            return new List<Team>(Connection.connection.Team.Where(a=>a.IsDeleted == false).ToList());
        }

        public static List<TypeCompetition> GetTypesCompetitions()
        {
            return new List<TypeCompetition>(Connection.connection.TypeCompetition).ToList();
        }

        public static List<Sportsman> GetSportsmans()
        {
            return new List<Sportsman>(Connection.connection.Sportsman.Where(a => a.IsDeleted == false).ToList());
        }

        public static List<Request> GetRequests()
        {
            return new List<Request>(Connection.connection.Request).ToList();
        }

        public static List<CategorySportsman> GetCategorySportsmans()
        {
            return new List<CategorySportsman>(Connection.connection.CategorySportsman).ToList();
        }

        public static Request GetRequestSportsmanProgram(int idSportsman, int idProgram)
        {
            return GetRequests().Where(a => a.IdSportsman == idSportsman && a.IdProgramCompetition == idProgram).FirstOrDefault();
        }

        public static List<Request> GetRequestsForProgramCompetition(ProgramCompetition pr)
        {
            return GetRequests().Where(a=>a.ProgramCompetition == pr).ToList();
        }

        public static List<ProgramCompetition> GetProgramsCompetition()
        {
            return new List<ProgramCompetition>(Connection.connection.ProgramCompetition).Where(a=>a.IsDeleted == false).ToList();
        }

        public static List<TypeProgram> GetTypesProgram()
        {
            return new List<TypeProgram>(Connection.connection.TypeProgram).ToList();
        }

        public static List<ProgramCompetition> GetProgramsInCompetition(Competition com)
        {
            return GetProgramsCompetition().Where(a=>a.IdCompetition == com.Id).ToList();
        }

        public static List<ResultCompetition> GetResultsCompetition()
        {
            return new List<ResultCompetition>(Connection.connection.ResultCompetition).Where(a=>a.IsDeleted == false).ToList();
        }

        public static List<ResultCompetition> GetResultsInProgramCompetition(ProgramCompetition com)
        {
            return GetResultsCompetition().Where(a => a.Request.IdProgramCompetition == com.Id).ToList();
        }

        public static List<Competition> GetCompetitions()
        {
            return new List<Competition>(Connection.connection.Competition.Where(a => a.IsDeleted == false).ToList());
        }

        public static List<Sportsman> GetSportmansInGenderAndTrainer(string gender)
        {
            List<Sportsman> list = new List<Sportsman>();
            foreach (var i in GetTeamsInTreaner(CurrentUser.trainer))
                foreach (var j in GetSportsmans().Where(a => a.IdTeam == i.IdTeam && a.Gender == gender))
                    list.Add(j) ;
            return list;
        }

        public static int GetScoreTeam(int idTeam)
        {
            int score = 0;
            foreach (var j in GetResultsCompetition().Where(a => a.Request.Sportsman.IdTeam == idTeam))
                score += j.Score;
            return score;
        }

        public static int GetScoreSportsman(int idSportsman)
        {
            int score = 0;
            foreach (var j in GetResultsCompetition().Where(a => a.Request.IdSportsman == idSportsman))
                score += j.Score;
            return score;
        }

        public static void RemoveTeam(int id)
        {
            Team team = Connection.connection.Team.FirstOrDefault(p => p.Id == id);
            team.IsDeleted = true;
            Connection.connection.SaveChanges();
        }

        public static List<City> GetCities()
        {
            return new List<City>(Connection.connection.City.ToList());
        }

        public static List<Sportsman> GetSportsmansInTeam(Team team)
        {
            return GetSportsmans().Where(a => a.IdTeam == team.Id).ToList();
        }

        public static void AddRequest(Request req)
        {
            Connection.connection.Request.Add(req);
            Connection.connection.SaveChanges();
        }

        public static void AddResult(ResultCompetition res, ProgramCompetition ProgCompet)
        {
            res.IsDeleted = false;
            Connection.connection.ResultCompetition.Add(res);
            Connection.connection.SaveChanges();

            List<ResultCompetition> list = DataAccess.GetResultsInProgramCompetition(ProgCompet).OrderBy(a => a.Result).ToList();
            List<ResultCompetition> listMetr = DataAccess.GetResultsInProgramCompetition(ProgCompet).OrderByDescending(a => a.Result).ToList();
            int count = 1;
            if (res.Request.ProgramCompetition.TypeCompetition.FormatResult.Name == "Метры и сантиметры")
            {
                for (int i = 0; i < listMetr.Count(); i++)
                {
                    listMetr[i].Rank = count;
                    if (count == 1)
                        listMetr[i].Score = 10;
                    else if (count == 2)
                        listMetr[i].Score = 7;
                    else if (count == 3)
                        listMetr[i].Score = 5;
                    else
                        listMetr[i].Score = 2;
                    Connection.connection.SaveChanges();
                    count++;
                }
            }
            else
            {
                for (int i = 0; i < list.Count(); i++)
                {
                    list[i].Rank = count;
                    if (count == 1)
                        list[i].Score = 10;
                    else if (count == 2)
                        list[i].Score = 7;
                    else if (count == 3)
                        list[i].Score = 5;
                    else
                        list[i].Score = 2;
                    Connection.connection.SaveChanges();
                    count++;
                }
            }
        }

        public static void SaveTeam(Team team)
        {
            if (team.Id == 0)
            {
                team.IsDeleted = false;
                Connection.connection.Team.Add(team);
                Connection.connection.SaveChanges();
                if (CurrentUser.user != null)
                {
                    Trainer_Team trainer_Team = new Trainer_Team()
                    {
                        Team = team,
                        Trainer = CurrentUser.trainer,
                        IsActive = true
                    };
                    Connection.connection.Trainer_Team.Add(trainer_Team);
                }
            }
            Connection.connection.SaveChanges();
        }

        public static void SaveSportsman(Sportsman sports)
        {
            sports.IsDeleted = false;
            if (sports.Id == 0)
                Connection.connection.Sportsman.Add(sports);
            Connection.connection.SaveChanges();
        }

        public static List<Trainer_Team> GetTrainersInTeam(Team team)
        {
            return GetTeamsTrainers().Where(a => a.IdTeam == team.Id).ToList();
        }

        public static List<Trainer_Team> GetTeamsTrainers()
        {
            return new List<Trainer_Team>(Connection.connection.Trainer_Team.Where(a => a.Team.IsDeleted == false && a.IsActive == true).ToList());
        }

        public static List<Trainer_Team> GetTeamsInTreaner(Trainer train)
        {
            return GetTeamsTrainers().Where(a => a.IdTrainer == train.Id).ToList();
        }

        public static List<Trainer> GetTrainers()
        {
            return new List<Trainer>(Connection.connection.Trainer.ToList());
        }

        public static bool IsCorrectUser(string email, string password)
        {
            var admin = GetUsers().Where(a => email == a.Login && password == a.Password && a.IdRole == 1);
            var trainer = GetUsers().Where(a => email == a.Login && password == a.Password && a.IdRole == 2);
            var sponsor = GetUsers().Where(a => email == a.Login && password == a.Password && a.IdRole == 3);

            if (trainer.Count() == 1)
            {
                CurrentUser.user = trainer.FirstOrDefault();
                CurrentUser.trainer = GetTrainer(CurrentUser.user.Id);
                return true;
            }
            else if (admin.Count() == 1)
            {
                CurrentUser.user = admin.FirstOrDefault();
                return true;
            }
            else if (sponsor.Count() == 1)
            {
                CurrentUser.user = sponsor.FirstOrDefault();
                return true;
            }
            else
                return false;
        }

        public static void SaveTrainer(Trainer trainer, User user)
        {
            if (trainer.Id == 0)
            {
                AddUser(user);
                trainer.User = GetUsers().LastOrDefault();
                Connection.connection.Trainer.Add(trainer);
            }
            Connection.connection.SaveChanges();
        }

        public static void SaveSponsorTeam(SponsorTeam spon)
        {
            if (spon.Id == 0)
            {
                Connection.connection.SponsorTeam.Add(spon);
            }
            Connection.connection.SaveChanges();
        }

        public static void SaveSponsor(Sponsor trainer, User user)
        {
            if (trainer.Id == 0)
            {
                AddUser(user);
                trainer.User = GetUsers().LastOrDefault();
                Connection.connection.Sponsor.Add(trainer);
            }
            Connection.connection.SaveChanges();
        }

        public static void SaveCompetition(Competition compet)
        {
            compet.IsDeleted = false;
            if (compet.Id == 0)
                Connection.connection.Competition.Add(compet);
            Connection.connection.SaveChanges();
        }

        public static void SaveProgramCompetition(ProgramCompetition compet)
        {
            compet.IsDeleted = false;
            if (compet.Id == 0)
            {
                Connection.connection.ProgramCompetition.Add(compet);
            }
            Connection.connection.SaveChanges();
        }

        public static void AddUser(User user)
        {
            Connection.connection.User.Add(user);
            Connection.connection.SaveChanges();
        }

        public static Trainer GetTrainer(int idUser)
        {
            return GetTrainers().Where(t => t.IdUser == idUser).FirstOrDefault();
        }
    }
}
