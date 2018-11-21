using System;
using RestSharp;

namespace Tidtabell.Helpers
{
    public static class RestRequestHelper
    {
        public static string Get(RestClient restClient)
        {
            var restRequest = new RestRequest(Method.GET);
            var restResponse = restClient.Execute(restRequest);

            return restResponse.Content;
        }
    }
}