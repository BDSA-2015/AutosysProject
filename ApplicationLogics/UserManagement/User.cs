﻿// User.cs is a part of Autosys project in BDSA-2015. Created: 17, 11, 2015.
// Creators: Dennis Thinh Tan Nguyen, William Diedricsehn Marstrand, Thor Valentin Aakjær Olesen Nielsen, 
// Jacob Mullit Møiniche.

using ApplicationLogics.Repository;

namespace ApplicationLogics.UserManagement
{
    public class User : IEntity
    {
        public string Name { get; internal set; }

        public string Metadata { get; set; }
        public int Id { get; set; }
    }
}