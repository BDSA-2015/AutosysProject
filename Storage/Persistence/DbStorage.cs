﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLogics.Repository;
using Storage.Repository;

namespace Storage.Persistence
{

    /// <summary>
    /// This class implements the IRepository interface outlining the CRUD operations to be used in the database. 
    /// These are used specifically on a given Dbcontext set in the main method in the Program class. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DbStorage<T> : IRepository<T> where T : class, IEntity
    {
        private DbContext _dbContext;

        public DbStorage(DbContext context)
        {
            _dbContext = context;
        }

        public int Create(T item)
        {
            _dbContext.Set<T>().Add(item);
            _dbContext.SaveChanges();
            return item.Id;
        }

        public T Read(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> Read()
        {
            return _dbContext.Set<T>();
        }

        public void Update(T item)
        {
            _dbContext.Set<T>().Attach(item);
            _dbContext.Entry<T>(item).State = EntityState.Modified;
        }

        public void Delete(T item)
        {
            _dbContext.Set<T>().Remove(item);
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

    }

}
