﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLogics.Repository;
using Storage.Entities;

namespace Storage.Repository
{
    public class TaskRepository : IRepository<StoredTaskRequest>
    {
        public int Create(StoredTaskRequest item)
        {
            throw new NotImplementedException();
        }

        public void Delete(StoredTaskRequest item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StoredTaskRequest> Read()
        {
            throw new NotImplementedException();
        }

        public StoredTaskRequest Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(StoredTaskRequest item)
        {
            throw new NotImplementedException();
        }
    }
}
