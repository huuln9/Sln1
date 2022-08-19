using BlazorApp1.Models;
using System.Net.Http.Json;

namespace BlazorApp1.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<EmployeeModel> GetEmployee(string id)
        {
            return await httpClient.GetFromJsonAsync<EmployeeModel>($"htest/employee/{id}");
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<List<EmployeeModel>>("htest/employee");
        }
    }
}
