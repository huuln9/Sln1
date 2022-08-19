
using Microsoft.AspNetCore.Components;
using BlazorApp1.Services;
using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class Employee
    {
        [Inject]
        private IEmployeeService EmployeeService { get; set; }

        public List<EmployeeModel> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await EmployeeService.GetEmployees();
        }
    }
}
