using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string Password = Console.ReadLine();

            try
            {
                var NameInOurDatabase = "";
                if ( !NameInOurDatabase.Contains(username))
                {
                    throw new UserNameInvalidException(username + " is not in our database");
                }
                if (Password != "123456")
                {
                    throw new UserPasswordInvalidException("Password was wrong");
                }
            }
            catch
            {
                throw;
            }
            //catch(UserNameInvalidException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch(UserPasswordInvalidException p)
            //{
            //    Console.WriteLine(p.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            Console.ReadKey();
        }
    }
    public class UserNameInvalidException : Exception
    {

        public UserNameInvalidException(string message):base(message)
        {
        }
    }
    public class UserPasswordInvalidException : Exception
    {
        public UserPasswordInvalidException(string message): base(message)
        {

        }
    }
}
