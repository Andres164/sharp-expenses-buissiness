﻿using SharpExpenses.Services.ApiServices.Contracts;

namespace SharpExpenses.Services.ApiServices
{
    public abstract class ApiServiceBase
    {
        protected readonly HttpClient _httpClient;
        protected abstract string ControllerEndpoint { get; }

        public ApiServiceBase(IHttpClientFactory clientFactory)
        {
            this._httpClient = clientFactory.CreateClient("API");
        }
    }
}
