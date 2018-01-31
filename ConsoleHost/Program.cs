using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AuthModel;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(DzoAuthService.AuthService)))
            {
                host.Open();
                Console.WriteLine("host opened");
                Console.ReadKey();
            }
        }
    }
}
