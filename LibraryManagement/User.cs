using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * Author: Leonardo Stifano
 * 
 */

namespace LibraryManagementSystem
{
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

        private string _role;

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public User(int userId, string firstName, string lastName, string role)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }
    }
}