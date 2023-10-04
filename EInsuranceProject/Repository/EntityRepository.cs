﻿using EInsuranceProject.Data;
using Microsoft.EntityFrameworkCore;

namespace EInsuranceProject.Repository
{
    public class EntityRepository<T> :IEntityRepository<T> where T : class

    {
        private readonly InsuranceContext _context;

        private readonly DbSet<T> _table;
        public EntityRepository(InsuranceContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public  async Task<IEnumerable<T>> GetAll(string[] innerTables)
        {
            IQueryable<T> query = _table;
            if(innerTables!=null)
            {
                foreach (var innerTable in innerTables)
                {
                    query = query.Include(innerTable); 
                }
            }
            return await query.ToListAsync();
        }
        public async Task<T> GetById(object id) 
        {
            return await _table.FindAsync(id);
        }
        public async Task Insert(T entity)
        {
            _table.Add(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> Update(T enitiy,int id)
        {
           T ExistingEntiy = await _table.FindAsync(enitiy);
            if(ExistingEntiy != null)
            {
                _context.Entry(ExistingEntiy).State = EntityState.Detached;
                 _table.Update(enitiy);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        public async Task<bool> Delete(object id)
        {

           T ExistingEntity= await _table.FindAsync(id);
            if(ExistingEntity!= null) 
            {
                _table.Remove(ExistingEntity); 
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }
    }
}
