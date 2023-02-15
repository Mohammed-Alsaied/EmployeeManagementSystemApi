using EmployeeManagementSystem.Service.Models;

namespace EmployeeManagementSystem.Service
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
