﻿using System;
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

        public static List<Gender> GetGenders()
        {
            return new List<Gender>(Connection.connection.Gender.ToList());
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
            return new List<ProgramCompetition>(Connection.connection.ProgramCompetition).ToList();
        }

        public static List<ProgramCompetition> GetProgramsInCompetition(Competition com)
        {
            return GetProgramsCompetition().Where(a=>a.IdCompetition == com.Id).ToList();
        }

        public static List<ResultCompetition> GetResultsCompetition()
        {
            return new List<ResultCompetition>(Connection.connection.ResultCompetition).ToList();
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

        public static void RemoveTrainerFromTeam(int idTeam)
        {
            Connection.connection.Trainer_Team.Remove(GetTeamsTrainers().Where(a => a.IdTeam == idTeam && CurrentUser.trainer == a.Trainer).FirstOrDefault());
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

        public static void AddResult(ResultCompetition res)
        {
            Connection.connection.ResultCompetition.Add(res);
            Connection.connection.SaveChanges();
        }

        public static void AddTeam(Team team)
        {
            team.IsDeleted = false;
            Connection.connection.Team.Add(team);
            Connection.connection.SaveChanges();
        }

        public static void AddSportsman(Sportsman sports)
        {
            Connection.connection.Sportsman.Add(sports);
            Connection.connection.SaveChanges();
        }

        public static void UpdateTeam(Team command)
        {
            var com = Connection.connection.Team.SingleOrDefault(r => r.Id == command.Id);
            com.IsDeleted = false;
            com.Name = command.Name;
            com.IdCity = command.IdCity;
            if (command.Image != null)
                com.Image = command.Image;
        }

        public static void UpdateSportsman(Sportsman command)
        {
            var com = Connection.connection.Sportsman.SingleOrDefault(r => r.Id == command.Id);
            com.IsDeleted = false;
            com.FullName = command.FullName;
            com.IdCity = command.IdCity;
            com.DateOfBirth = command.DateOfBirth;
            com.Gender = command.Gender;
            com.Height = command.Height;
            com.Weight = com.Weight;
            com.PhoneNumber = com.PhoneNumber;
            com.CategorySportsman = command.CategorySportsman;
            com.Team = command.Team;
            if (command.Image != null)
                com.Image = command.Image;
            Connection.connection.SaveChanges();
        }

        public static List<Trainer_Team> GetTrainersInTeam(Team team)
        {
            return GetTeamsTrainers().Where(a => a.IdTeam == team.Id).ToList();
        }

        public static List<Trainer_Team> GetTeamsTrainers()
        {
            return new List<Trainer_Team>(Connection.connection.Trainer_Team.Where(a => a.Team.IsDeleted == false).ToList());
        }

        public static List<Trainer_Team> GetTeamsInTreaner(Trainer train)
        {
            return GetTeamsTrainers().Where(a => a.IdTrainer == train.Id).ToList();
        }

        public static List<Trainer> GetTrainers()
        {
            return new List<Trainer>(Connection.connection.Trainer.ToList());
        }

        public static int IsCorrectUser(string email, string password)
        {
            var admin = GetUsers().Where(a => email == a.Login && password == a.Password && a.IdRole == 1);
            var trainer = GetUsers().Where(a => email == a.Login && password == a.Password && a.IdRole == 2);
            var sponsor = GetUsers().Where(a => email == a.Login && password == a.Password && a.IdRole == 3);

            if (trainer.Count() == 1)
            {
                CurrentUser.user = trainer.FirstOrDefault();
                CurrentUser.trainer = GetTrainer(CurrentUser.user.Id);
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

        public static Trainer GetTrainer(int idUser)
        {
            return GetTrainers().Where(t => t.IdUser == idUser).FirstOrDefault();
        }
    }
}
