using System.Threading.Tasks;

namespace DatingApp.API.QueryFactories
{
    public interface IQuery<T>
    {
        Task<T> ExecuteAsync(); 
    }
}