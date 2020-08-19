using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesBase.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username {get;set; }
        public string Password {get;set; }
        public string LastName {get;set; }
        public int RolCode {get;set; }
        public bool SaveUser { get; set; }

        public User(int id, string username, string password, string LlstName, int rolCode)
        {
            Id = id;
            Username= username;
            Password= password;
            LastName= LlstName;
            RolCode = rolCode;
            SaveUser = false;
        }

        public User()
        {
            SaveUser = false;
        }
    }
}
