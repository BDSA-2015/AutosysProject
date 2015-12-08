﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Entities;
using Storage.Models;
using Storage.Repository.Interface;

namespace Storage.Repository
{

    /// <summary>
    /// This class outlines the CRUD operations used to store teams in the database. 
    /// </summary>
    public class TeamRepository : DbRepository<StoredTeam>
    {
        
    }

}
