using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrganizationAthleticsCompetitions;
using OrganizationAthleticsCompetitions.DataBase;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestIsCorrectUser()
        {
            Assert.AreEqual(DataAccess.IsCorrectUser("2003", "2003"), true); //проверка на правильность логина и пароля админа
            Assert.AreEqual(DataAccess.IsCorrectUser("0", "0"), false); //проверка на неправильность логина и пароля
        }

        [TestMethod]
        public void TestRegistrationUser()
        {
            User user = new User
            {
                FullName = "Максимов Максим Максимович",
                Login = "zaysev@mail.ru",
                Password = "fghj45!",
                IdRole = 2
            };
            Trainer train = new Trainer();
            DataAccess.SaveTrainer(train, user); // добавление пользователя

            Assert.IsTrue(DataAccess.GetUsers().Contains(user));

            Assert.IsTrue(DataAccess.GetTrainers().Contains(train));
        }

        [TestMethod]
        public void TestCommands()
        {
            Team com = new Team { Name = "Алые Паруса", IdCity = 1 };
            DataAccess.SaveTeam(com); // добавление команды
            Assert.IsTrue(DataAccess.GetTeams().Contains(com));

            DataAccess.RemoveTeam(DataAccess.GetTeams().Last().Id); // удаление команды
            Assert.IsFalse(DataAccess.GetTeams().Contains(com));

            Team updateCommand = new Team { Id=8,  Name = "Машины", IdCity = 5 };
            DataAccess.SaveTeam(updateCommand); // редактирование команды
            Assert.IsFalse(DataAccess.GetTeams().Contains(updateCommand));
        }
    }
}
