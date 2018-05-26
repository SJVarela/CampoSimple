using DataAccess.TableGateways;

namespace DataAccess.Repository
{
    public class Repository
    {
        public UserGateway Users { get; } = new UserGateway();
    }
}
