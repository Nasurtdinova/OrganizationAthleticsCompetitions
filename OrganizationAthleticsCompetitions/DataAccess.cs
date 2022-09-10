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
