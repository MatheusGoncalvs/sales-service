using System.Threading.Tasks;
using Sales.Core.Messages;

namespace Sales.Core.Bus
{
    public interface IMediatrHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;
    }
}