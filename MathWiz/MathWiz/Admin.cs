﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathWiz
{
    public class Admin : User
    {
        //empty constructor
        public Admin() : base() { }

        //full constructor
        public Admin(string username, string firstName, string lastName, string password) : base(username, firstName, lastName, password)
        {

        }
    }
}