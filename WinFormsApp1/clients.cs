using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class clients
    {
        public int User_id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Registration_date { get; set; }
        public string Phone_number { get; set; }

        public clients(int user_id, string login, string password, string name, string registration_date, string phone_number)
        {
            User_id = user_id;
            Login = login;
            Password = password;
            Name = name;
            Registration_date = registration_date;
            Phone_number = phone_number;
        }
    }
}
