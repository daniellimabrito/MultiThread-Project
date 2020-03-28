using FinalProject.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly DbSet<TEntity> dbSet;
        protected readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }

        public virtual void Add(TEntity obj)
        {
           
            _context.Add(obj);
            SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
           return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Remove(Guid id)
        {
            var obj = _context.Set<TEntity>().Find(id);
            _context.Remove(obj);
            SaveChanges();

        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _context.Update(obj);
            SaveChanges();
        }
    }
}
