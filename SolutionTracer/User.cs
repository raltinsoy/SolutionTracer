using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionTracer
{
    public class User
    {
        public int Id { get; }

        public string Name => "User " + Id;

        public string Phone { get; }

        public User(int id, string phone)
        {
            Id = id;
            Phone = phone;
        }

        public bool IsPhoneValid()
        {
            if (Phone.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
