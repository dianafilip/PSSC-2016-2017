﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PSSC.Models.Repositories
{
    public class Repository<T> where T: class
    {
        private ContextFacultate context = null;
        protected DbSet<T> DbSet { get; set; }
        public Repository()
        {
            context = new ContextFacultate();
            DbSet = context.Set<T>();
        }

        public Repository(ContextFacultate context)
        {
            this.context = context;
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}