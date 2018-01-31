using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ActsModel;
using AuthModel;

namespace DzoAuthService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class AuthService : IAuthService
    {

        public Token Authenticate(string login, string password)
        {
            using (var db = new UsersDataModel())
            {
                var users = db.Users.Where(x => x.Login == login);
                var authenticated = users.Count() == 1 && users.First().Password == password;
                var token = authenticated ? new Token(users.First()) : null;
                return token;
            }
        }

        public List<Act> GetActs(Token token)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.Acts.ToList();
                return db.Acts.Where(x => x.CreatorRegion == token.UserRegion).ToList();
            }
        }

        public bool DeleteAct(Act act, Token token)
        {
            if (!Token.Exists(token)) return false;
            using (var db = new DzoContext())
            {
                try
                {
                    bool res = false;
                    var acts = db.Acts.ToList();
                    Act _act = null;
                    if (acts.Contains(act))
                        _act = acts.First(x => x.Equals(act));
                    if (_act != null)
                    {
                        db.Acts.Remove(_act);
                        res = true;
                    }

                    db.SaveChanges();
                    return res;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool AddAct(Act act, Token token)
        {
            if (!Token.Exists(token)) return false;
            using (var db = new DzoContext())
            {
                try
                {
                    var res = db.Acts.Add(act) != null;
                    db.SaveChanges();
                    return res;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
