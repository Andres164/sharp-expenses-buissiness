﻿using SharedModels.Models;
using SharedModels.Models.ViewModels;
using SharpExpenses.Services.ApiServices.Contracts;
using System.Net.Http.Json;

namespace SharpExpenses.Services.ApiServices
{
    public class ExpenseCategoriesService : ApiServiceBase, IExpenseCategoriesService
    {
        protected override string ControllerEndpoint => "api/ExpenseCategories";

        public ExpenseCategoriesService(IHttpClientFactory httpClientFactory)
            : base(httpClientFactory)
        {

        }


        public async Task<List<ExpenseCategory>> ReadAll()
        {
            var response = await _httpClient.GetAsync(ControllerEndpoint);
            response.EnsureSuccessStatusCode();
            var categories = await response.Content.ReadFromJsonAsync<List<ExpenseCategory>>();
            return categories!; // categories cannot be null, as the API always return a list
        }

        public async Task<ExpenseCategoryViewModel?> Read(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task Create(ExpenseCategoryViewModel newCategory)
        {
            var response = await this._httpClient.PostAsJsonAsync(ControllerEndpoint, newCategory);
            response.EnsureSuccessStatusCode();
        }

        public async Task<ExpenseCategory?> Update(int categoryId, ExpenseCategoryViewModel updatedCategory)
        {
            var response = await this._httpClient.PutAsJsonAsync($"{ControllerEndpoint}/{categoryId}", updatedCategory);
            var updatedCategory = 
        }

        public async Task<ExpenseCategory?> Delete(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
