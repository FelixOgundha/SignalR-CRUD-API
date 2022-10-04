using API.Models;

namespace API.Hubs.Clients
{
    public interface IEmployeesHub
    {
        Task ReceiveNewEmployee(NewEmployee employee);
    }
}
