using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ActsModel;
using ActsModel.Model;

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

        public List<ActBase> GetActs(Token token, int count, int offset)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.Acts.OrderBy(x => x.Id).Skip(offset).Take(count).ToList();
                return db.Acts.Where(x => x.Region == token.UserRegion).OrderBy(x => x.Id).Skip(offset).Take(count).ToList();
            }
        }

        public List<ActBase> GetSomeActs(Token token, Func<ActBase, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.Acts.Where(predicate).ToList();
                return db.Acts.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<ActCommon> GetActsCommon(Token token, Func<ActCommon, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.CommonActs.Where(predicate).ToList();
                return db.CommonActs.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<ActIndividual> GetActsIndividual(Token token, Func<ActIndividual, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.IndividualActs.Where(predicate).ToList();
                return db.IndividualActs.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<ActInpectationFl> GetActsInpectationFl(Token token, Func<ActInpectationFl, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.ActsInspectionFl.Where(predicate).ToList();
                return db.ActsInspectionFl.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<ActInspectationUlIp> GetActsInspectationUlIp(Token token, Func<ActInspectationUlIp, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.ActsInspectionUlIp.Where(predicate).ToList();
                return db.ActsInspectionUlIp.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<ActInspection> GetActInspection(Token token, Func<ActInspection, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.ActsInspection.Where(predicate).ToList();
                return db.ActsInspection.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<AgreementStatement> GetAgreementStatements(Token token, Func<AgreementStatement, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.AgreementStatements.Where(predicate).ToList();
                return db.AgreementStatements.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<AreaMeasurement> GetAreaMeasurements(Token token, Func<AreaMeasurement, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.AreaMeasurements.Where(predicate).ToList();
                return db.AreaMeasurements.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<CheckingJournal> GetCheckingJournals(Token token, Func<CheckingJournal, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.CheckingJournals.Where(predicate).ToList();
                return db.CheckingJournals.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<CitizensCheckPlan> GetCitizensCheckPlans(Token token, Func<CitizensCheckPlan, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.CitizensCheckPlans.Where(predicate).ToList();
                return db.CitizensCheckPlans.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<OrderInspectionUlIp> GetOrdersInspectionUlIp(Token token, Func<OrderInspectionUlIp, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.OrderInspectionsUlIp.Where(predicate).ToList();
                return db.OrderInspectionsUlIp.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<PhotoTable> GetPhotoTables(Token token, Func<PhotoTable, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.PhotoTables.Where(predicate).ToList();
                return db.PhotoTables.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<Protocol> GetProtocols(Token token, Func<Protocol, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.Protocols.Where(predicate).ToList();
                return db.Protocols.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<Regulation> GetRegulations(Token token, Func<Regulation, bool> predicate)
        {
            if (!Token.Exists(token)) return null;
            using (var db = new DzoContext())
            {
                if (token.UserRegion == Region.All) return db.Regulations.Where(predicate).ToList();
                return db.Regulations.Where(x => x.Region == token.UserRegion).AsEnumerable().Where(predicate).ToList();
            }
        }

        public List<Photo> GetPhotoTablePhotos(Token token, PhotoTable photoTable)
        {
            if (!Token.Exists(token)) return null;
            try
            {
                using (var db = new DzoContext())
                {
                    //return db.PhotoTables.Where(x=>x.Id == photoTable.Id)
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateAct(ActBase act, Token token)
        {
            if (!Token.Exists(token)) return false;
            try
            {
                using (var db = new DzoContext())
                {
                    var old = db.Acts.First(x => x.Id == act.Id);
                    db.Acts.Remove(old);
                    db.Acts.Add(act);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteActById(int id, Token token)
        {
            if (!Token.Exists(token)) return false;
            try
            {
                using (var db = new DzoContext())
                {
                    var old = db.Acts.First(x => x.Id == id);
                    db.Acts.Remove(old);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool DeleteAct(ActBase act, Token token)
        {
            if (!Token.Exists(token)) return false;
            try
            {
                if (token.UserRegion == Region.All)
                {
                    using (var db = new DzoContext())
                    {
                        var result = db.Acts.Remove(act) != null;
                        db.SaveChanges();
                        return result;
                    }
                }

                if (act.Region != token.UserRegion) return false;
                using (var db = new DzoContext())
                {
                    var result = db.Acts.Remove(act) != null;
                    db.SaveChanges();
                    return result;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool AddAct(ActBase act, Token token)
        {
            if (!Token.Exists(token)) return false;
            act.Region = token.UserRegion;
            var type = act.GetType();
            try
            {
                using (var db = new DzoContext())
                {
                    var ok = false;
                    if (type == typeof(ActBase)) ok = db.Acts.Add(act) != null;
                    if (type == typeof(ActCommon)) ok = db.CommonActs.Add(act as ActCommon ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(ActIndividual)) ok = db.IndividualActs.Add(act as ActIndividual ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(ActInpectationFl)) ok = db.ActsInspectionFl.Add(act as ActInpectationFl ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(ActInspectationUlIp)) ok = db.ActsInspectionUlIp.Add(act as ActInspectationUlIp ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(ActInspection)) ok = db.ActsInspection.Add(act as ActInspection ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(AgreementStatement)) ok = db.AgreementStatements.Add(act as AgreementStatement ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(AreaMeasurement)) ok = db.AreaMeasurements.Add(act as AreaMeasurement ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(CheckingJournal)) ok = db.CheckingJournals.Add(act as CheckingJournal ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(CitizensCheckPlan)) ok = db.CitizensCheckPlans.Add(act as CitizensCheckPlan ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(OrderInspectionUlIp)) ok = db.OrderInspectionsUlIp.Add(act as OrderInspectionUlIp ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(PhotoTable)) ok = db.PhotoTables.Add(act as PhotoTable ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(Protocol)) ok = db.Protocols.Add(act as Protocol ?? throw new InvalidOperationException()) != null;
                    if (type == typeof(Regulation)) ok = db.Regulations.Add(act as Regulation ?? throw new InvalidOperationException()) != null;
                    db.SaveChanges();
                    return ok;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
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
