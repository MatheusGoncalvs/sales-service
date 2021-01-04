using System.Threading.Tasks;

namespace Sales.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}