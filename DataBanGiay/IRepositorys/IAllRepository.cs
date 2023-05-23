using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBanGiay.Model;
namespace DataBanGiay.IRepositorys
{
    public interface IAllRepository<T>
    {
        public IEnumerable<T> GetAll();
        public bool Create(T item);
        public bool Update(T item);
        public bool Delete(T item);
    }
}
