using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ServiceStack;
using static Console.Utils;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user = new UserModel() { ID = 5, IsActive = true, Name = "User A" };

                var result = user.ToJson();

                LogApiInfo("This is web api");

                var result2 = result.FromJson<UserModel>();

                WriteLine(result2.Name);
            }
            catch (Exception ex)
            {
                LogWebError(ex);
            }
            finally
            {
                WriteLine("Any key to exit");
                Read();
            }
        }
    }
}
