using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ActsModel;

namespace DzoAuthService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class AuthService : IAuthService
    {

        public Token Authenticate(string login, string password)
        {
            using (var db = new DzoContext())
            {
                var users = db.Users.Where(x => x.Login == login);
                var authenticated = users.Count() == 1 && users.First().Password == password;
                var token = authenticated ? new Token(users.First()) : null;
                return token;
            }
        }

        public List<Act> GetActs(Token token, int count, int offset)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.Acts.OrderBy(x=>x.Id).Skip(offset).Take(count).ToList();
                return db.Acts.Where(x => x.CreatorRegion == token.UserRegion).OrderBy(x=>x.Id).Skip(offset).Take(count).ToList();
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

        public bool AddUser(string adminPassword, User user)
        {
            try
            {
                using (var db = new DzoContext())
                {
                    if (db.Users.First(x => x.Login == "admin").Password == adminPassword)
                    {
                        if (!db.Users.Any(x => x.Login == user.Login))
                        {
                            db.Users.Add(user);
                            db.SaveChanges();
                            return true;
                        }

                        Console.WriteLine("This user already exists!");
                    }
                    else Console.WriteLine("Password is incorrect!");

                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
                return false;
            }
        }
    }
}
