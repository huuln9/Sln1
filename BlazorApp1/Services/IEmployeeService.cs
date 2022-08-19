using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetEmployees();

        Task<EmployeeModel> GetEmployee(string id);
    }
}
