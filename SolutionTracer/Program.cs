using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTracer
{
    public class Program
    {
        private static readonly List<User> _users = new List<User>();

        static void Main(string[] args)
        {
            var user1 = AddUser(1, "12345678912"); //valid phone number
            var user2 = AddUser(2, "123"); //invalid phone number

            var isPhoneValid = user1.IsPhoneValid();
            isPhoneValid = user2.IsPhoneValid();
        }

        private static User AddUser(int id, string phone)
        {
            var user = new User(id, phone);
            _users.Add(user);
            return user;
        }
    }
}
