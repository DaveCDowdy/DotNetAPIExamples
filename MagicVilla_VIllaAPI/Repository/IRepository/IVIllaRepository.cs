using MagicVilla_VIllaAPI.Models;
using System.Linq.Expressions;

namespace MagicVilla_VIllaAPI.Repository.IRepository
{
    public interface IVIllaRepository
    {
        Task<List<Villa>> GetAll(Expression<Func<Villa>> filter = null);
        Task<Villa> Get(Expression<Func<Villa>> filter = null, bool tracked = true);
        Task Create(Villa entity);
        Task Remove(Villa entity);
        Task Save();
    }
}
