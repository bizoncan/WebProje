﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using veriErisimK.Abstract;
using veriErisimK.Concrete;

namespace veriErisimK.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var c = new context();
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetbyFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetById(int id)
        {
            using var c = new context();
            return c.Set<T>().Find(id);

        }

        public List<T> GetList()
        {
            using var c = new context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
