using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AuthModel;

namespace DzoAuthService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AuthService.svc or AuthService.svc.cs at the Solution Explorer and start debugging.
    public class AuthService : IAuthService
    {
        public bool Authenticate(string login, string password)
        {
            using (var db = new UsersDataModel())
            {
                var users = db.Users.Where(x => x.Login == login);
                return users.Count() == 1 && users.First().Password == password;
            }
        }
    }
}
