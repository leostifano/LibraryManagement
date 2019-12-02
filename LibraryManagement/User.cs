using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagementSystem
{

    enum Roles
    {
        Member, Librarian, Admin
    }

    abstract class User
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private Roles _role;

        public Roles Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public User(int userId, string firstName, string lastName, Roles role)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
    }
}