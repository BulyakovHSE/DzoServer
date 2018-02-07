using System;
using System.Collections.Generic;
using System.IO;
using ActsModel;
using Newtonsoft.Json;

namespace DzoAuthService
{
    [Serializable]
    public class Token
    {
        private static readonly Random Rand = new Random();
        private static readonly string FileName = "Tokens.json";
        private static readonly object LockThis = new object();

        public Token(){}

        public Token(User user)
        {
            do
            {
                TokenKey = "";
                for (int i = 0; i < 30; i++)
                {
                    TokenKey += (char) Rand.Next(48, 91);
                }
            } while (CheckKeyExistsInFile(TokenKey));
            ExpirationTime = DateTime.Now;
            UserRegion = user.Region;
            AddTokenToFile(this);
        }

        public string TokenKey { get; set; }

        public DateTime ExpirationTime { get; set; }

        public Region UserRegion; 

        public override bool Equals(object obj)
        {
            if (!(obj is Token token)) return false;
            return TokenKey == token.TokenKey && ExpirationTime == token.ExpirationTime;
        }

        public override int GetHashCode()
        {
            return TokenKey.GetHashCode() + ExpirationTime.GetHashCode();
        }

        public static void AddTokenToFile(Token token)
        {
            lock (LockThis)
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader f = new StreamReader(file);
                var tokens = JsonConvert.DeserializeObject<List<Token>>(f.ReadToEnd()) ?? new List<Token>();
                tokens.Add(token);
                var result = JsonConvert.SerializeObject(tokens);
                f.Close();
                file.Close();
                file = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                var writer = new StreamWriter(file);
                writer.Write(result);
                writer.Close();
                file.Close();
            }
        }

        public static bool CheckKeyExistsInFile(string token)
        {
            lock (LockThis)
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader f= new StreamReader(file);
                var tokens = JsonConvert.DeserializeObject<List<Token>>(f.ReadToEnd());
                var result = tokens?.Exists(x => x.TokenKey == token) ?? false;
                f.Close();
                file.Close();
                return result;
            }
        }

        public static bool Exists(Token token)
        {
            lock (LockThis)
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader f= new StreamReader(file);
                var tokens = JsonConvert.DeserializeObject<List<Token>>(f.ReadToEnd());
                var result = tokens?.Exists(x => x.Equals(token)) ?? false;
                f.Close();
                file.Close();
                return result;
            }
            
        }

        public static void DeleteExpiredTokens()
        {
            lock (LockThis)
            {
                FileStream file = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader f= new StreamReader(file);
                var tokens = JsonConvert.DeserializeObject<List<Token>>(f.ReadToEnd()) ?? new List<Token>();
                tokens.RemoveAll(token => DateTime.Now - token.ExpirationTime > TimeSpan.FromHours(1));
                f.Close();
                file.Close();
                file = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                var writer = new StreamWriter(file);
                writer.Write(JsonConvert.SerializeObject(tokens));
                writer.Close();
                file.Close();
            }
            
        }
    }
}