using System.Threading.Tasks;

namespace connect_back.Domain.Repositories
{//Finalizar transaccion.
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}