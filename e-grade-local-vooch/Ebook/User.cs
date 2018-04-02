using System;
using System.ComponentModel.DataAnnotations;

namespace Ebook
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        private string login;
        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }
        private string password;
        private string role;

        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                role = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public User(string login1, string role1,string pass)
        {

            login = login1;
            role = role1;
            password = pass;
        }

    }
}
