using Microsoft.AspNetCore.Components;
using Northwind.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorShell.Services
{
    public class NorthwindService : INorthwindService
    {
        private readonly HttpClient httpClient;

        public NorthwindService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<List<Employee>> GetAllEmployeesAsync()
        {
            return httpClient.GetJsonAsync<List<Employee>>("http://localhost:52265/api/values");
        }

    }
}
