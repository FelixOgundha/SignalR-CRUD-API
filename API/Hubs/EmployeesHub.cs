using API.Hubs.Clients;
using API.Models;
using Microsoft.AspNetCore.SignalR;

namespace API.Hubs
{
    public class EmployeesHub : Hub<IEmployeesHub>
    {
        public async Task ReceiveNewEmployee(NewEmployee employee)
        {
            await Clients.All.ReceiveNewEmployee(employee);
        }
    }
}
