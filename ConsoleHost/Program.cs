using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using DlrModel;
//using ActsModel;
using DlrModel.Model;
using DzoAuthService;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (ConsoleFuncs.HorizontalMenu("Start host", "Add new user"))
            {
                case 0:
                    {
                        using (var host = new ServiceHost(typeof(AuthService)))
                        {
                            Token.DeleteExpiredTokens();
                            host.Open();
                            Console.WriteLine("host opened");
                            Console.ReadLine();
                        }
                        break;
                    }
                case 1:
                    {
                        var service = new AuthService();
                        Console.Write("Enter admin password: ");
                        var adminPass = Console.ReadLine();
                        string pass, pass2;
                        Console.Write("Enter login: ");
                        var login = Console.ReadLine();
                        do
                        {
                            Console.Write("Enter password: ");
                            pass = Console.ReadLine();

                            Console.Write("Confirm password: ");
                            pass2 = Console.ReadLine();
                            if (pass != pass2) Console.WriteLine("Passwords are not equal!");
                        } while (pass != pass2);

                        bool ok;
                        Console.WriteLine($"0 - {Region.All}");
                        Console.WriteLine($"1 - {Region.Industrial}");
                        Console.WriteLine($"2 - {Region.Dzerzhinsky}");
                        Console.WriteLine($"3 - {Region.Kirov}");
                        Console.WriteLine($"4 - {Region.Leninsky}");
                        Console.WriteLine($"5 - {Region.Motovilikhinsky}");
                        Console.WriteLine($"6- {Region.Ordzhonikidzevsky}");
                        Console.WriteLine($"7 - {Region.Sverdlovsky}");
                        Console.WriteLine($"8 - {Region.NewLyads}");
                        Console.Write("Enter region number: ");
                        Region reg;
                        do
                        {
                            ok = Enum.TryParse(Console.ReadLine(), true, out reg);
                            if (!ok) Console.WriteLine("Entered region not exist! Try write region by its number.");
                        } while (!ok);

                        if (service.AddUser(adminPass, new User() { Login = login, Password = pass, Region = reg }))
                        {
                            Console.WriteLine($"User {login} was successesfully added!");
                        }
                        Main(null);
                        break;
                    }

            }


        }
    }
}
