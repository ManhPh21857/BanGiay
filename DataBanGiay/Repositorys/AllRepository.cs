using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBanGiay.IRepositorys;
using DataBanGiay.Model;
using Microsoft.EntityFrameworkCore;

namespace DataBanGiay.Repositorys
{
    public class AllRepository<T> : IAllRepository<T> where T : class
    {
        BanGiayDBConText context;
        DbSet<T> dbset;
        public AllRepository(BanGiayDBConText context, DbSet<T> dbset)
        {
            this.context = context;
            this.dbset = dbset;
        }
        public bool Create(T item)
        {
            try
            {
                dbset.Add(item);
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool Delete(T item)
        {
            try
            {
                dbset.Remove(item);
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public bool Update(T item)
        {
            try
            {
                dbset.Update(item);
                context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
